using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;
using DadTalks.Properties;

namespace DadTalks
{
    public partial class MainWindow : Form
    {
        private readonly SpeechSynthesizer _speechSynthesizer = new();

        public MainWindow()
        {
            InitializeComponent();

            // Configure the audio output.   
            _speechSynthesizer.SetOutputToDefaultAudioDevice();
            FillVoicesMenu();
            HighlightTextbox();
            SelectVoice(AppSettings.Default.Voice);
            _inputTextbox.Select();
        }

        private bool PlaySpeech(string? speech)
        {
            if (String.IsNullOrWhiteSpace(speech))
            {
                return false;
            }

            if (_speechSynthesizer.State != SynthesizerState.Ready)
            {
                _speechSynthesizer.SpeakAsyncCancelAll();
            }

            _speechSynthesizer.SpeakAsync(speech);

            return true;
        }

        private void PlaySelectedSpeech(bool textboxOnly = false)
        {
            if (_historyListbox.SelectedIndex >= 0 && !textboxOnly)
            {
               var  speech = _historyListbox.SelectedItem as string;
               PlaySpeech(speech);
            }
            else
            {
                var speech = _inputTextbox.Text;
                if (PlaySpeech(speech))
                {
                   _historyListbox.Items.Add(_inputTextbox.Text);
                   _inputTextbox.Text = String.Empty;
                }
            }
        }

        private void SelectPreviousSpeechItem()
        {
            if (_historyListbox.Items.Count == 0)
            {
                return;
            }

            if (_historyListbox.SelectedIndex == -1)
            {
                RemoveTextboxHighlight();
                _historyListbox.SelectedIndex = _historyListbox.Items.Count - 1;
            }
            else if (_historyListbox.SelectedIndex > 0)
            {
                _historyListbox.SelectedIndex -= 1;
            }
        }

        private void SelectNextSpeechItem()
        {
            if (_historyListbox.Items.Count == 0)
            {
                return;
            }

            else if ((_historyListbox.SelectedIndex > -1)
                && (_historyListbox.SelectedIndex < _historyListbox.Items.Count - 1))
            {
                _historyListbox.SelectedIndex += 1;
            }
            else
            {
                _historyListbox.SelectedIndex = -1;
                HighlightTextbox();
            }
        }

        private void HighlightTextbox()
        {
            _inputTextbox.BackColor = Color.DarkBlue;
            _inputTextbox.ForeColor = SystemColors.HighlightText;
        }

        private void RemoveTextboxHighlight()
        {
            _inputTextbox.BackColor = SystemColors.Window;
            _inputTextbox.ForeColor = SystemColors.WindowText;
        }

        private void FillVoicesMenu()
        {
            var voiceList = _speechSynthesizer.GetInstalledVoices();
            var toolstripItems = voiceList
                .Where(v => v.Enabled)
                .Select(v => new ToolStripMenuItem(v.VoiceInfo.Name, null, (sender, e) => SelectVoice(v.VoiceInfo.Name)));
            _voicesToolStripMenuItem.DropDownItems.AddRange(toolstripItems.ToArray());
        }

        private void SelectVoice(string name)
        {
            try
            {
                _speechSynthesizer.SelectVoice(name);

                AppSettings.Default.Voice = name;
                AppSettings.Default.Save();
                _inputTextbox.Select();
            } catch (Exception ex)
            {
                MessageBox.Show($"Unable to select voice: {name}. Using default voice instead. {ex.Message}",
                    "Speech Synthesis Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void _talkButton_Click(object sender, EventArgs e)
        {
            PlaySelectedSpeech(textboxOnly: true);
            _inputTextbox.Select();
        }

        private void MainWindow_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.PageUp)
            {
                SelectPreviousSpeechItem();   
            }
            else if (e.KeyCode == Keys.PageDown)
            {
                SelectNextSpeechItem();
            }
            else if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                PlaySelectedSpeech();
            }
        }
    }
}
