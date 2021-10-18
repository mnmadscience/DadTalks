namespace DadTalks
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this._historyListbox = new System.Windows.Forms.ListBox();
            this._inputTextbox = new System.Windows.Forms.TextBox();
            this._inputPanel = new System.Windows.Forms.Panel();
            this._talkButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this._voicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._inputPanel.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _historyListbox
            // 
            this._historyListbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._historyListbox.FormattingEnabled = true;
            this._historyListbox.ItemHeight = 28;
            this._historyListbox.Location = new System.Drawing.Point(0, 30);
            this._historyListbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._historyListbox.Name = "_historyListbox";
            this._historyListbox.Size = new System.Drawing.Size(782, 523);
            this._historyListbox.TabIndex = 0;
            // 
            // _inputTextbox
            // 
            this._inputTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._inputTextbox.BackColor = System.Drawing.Color.DarkBlue;
            this._inputTextbox.Location = new System.Drawing.Point(4, 4);
            this._inputTextbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._inputTextbox.Multiline = true;
            this._inputTextbox.Name = "_inputTextbox";
            this._inputTextbox.PlaceholderText = "Enter the text to say here.";
            this._inputTextbox.Size = new System.Drawing.Size(625, 73);
            this._inputTextbox.TabIndex = 1;
            // 
            // _inputPanel
            // 
            this._inputPanel.Controls.Add(this._talkButton);
            this._inputPanel.Controls.Add(this._inputTextbox);
            this._inputPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._inputPanel.Location = new System.Drawing.Point(0, 470);
            this._inputPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._inputPanel.Name = "_inputPanel";
            this._inputPanel.Size = new System.Drawing.Size(782, 83);
            this._inputPanel.TabIndex = 2;
            // 
            // _talkButton
            // 
            this._talkButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._talkButton.Location = new System.Drawing.Point(637, 15);
            this._talkButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._talkButton.Name = "_talkButton";
            this._talkButton.Size = new System.Drawing.Size(129, 50);
            this._talkButton.TabIndex = 2;
            this._talkButton.Text = "Play";
            this._talkButton.UseVisualStyleBackColor = true;
            this._talkButton.Click += new System.EventHandler(this._talkButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._voicesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(782, 30);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // _voicesToolStripMenuItem
            // 
            this._voicesToolStripMenuItem.Name = "_voicesToolStripMenuItem";
            this._voicesToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this._voicesToolStripMenuItem.Text = "Voices";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this._inputPanel);
            this.Controls.Add(this._historyListbox);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dad Talk!";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainWindow_KeyDown);
            this._inputPanel.ResumeLayout(false);
            this._inputPanel.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox _historyListbox;
        private System.Windows.Forms.TextBox _inputTextbox;
        private System.Windows.Forms.Panel _inputPanel;
        private System.Windows.Forms.Button _talkButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem _voicesToolStripMenuItem;
    }
}
