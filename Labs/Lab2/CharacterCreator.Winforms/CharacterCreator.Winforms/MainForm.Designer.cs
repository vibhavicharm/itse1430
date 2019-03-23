namespace CharacterCreator.Winforms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.onFile = new System.Windows.Forms.ToolStripMenuItem();
            this.onFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.onHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.onHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.onCharacter = new System.Windows.Forms.ToolStripMenuItem();
            this.onCharacterNew = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.onFile,
            this.onHelp,
            this.onCharacter});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(554, 28);
            this.menuStrip1.TabIndex = 0;
            // 
            // onFile
            // 
            this.onFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.onFileExit});
            this.onFile.Name = "onFile";
            this.onFile.Size = new System.Drawing.Size(44, 24);
            this.onFile.Text = "&File";
            // 
            // onFileExit
            // 
            this.onFileExit.Name = "onFileExit";
            this.onFileExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.onFileExit.Size = new System.Drawing.Size(161, 26);
            this.onFileExit.Text = "&Exit";
            this.onFileExit.Click += new System.EventHandler(this.onFileExit_Click);
            // 
            // onHelp
            // 
            this.onHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.onHelpAbout});
            this.onHelp.Name = "onHelp";
            this.onHelp.Size = new System.Drawing.Size(53, 24);
            this.onHelp.Text = "&Help";
            // 
            // onHelpAbout
            // 
            this.onHelpAbout.Name = "onHelpAbout";
            this.onHelpAbout.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F)));
            this.onHelpAbout.Size = new System.Drawing.Size(216, 26);
            this.onHelpAbout.Text = "&About";
            this.onHelpAbout.Click += new System.EventHandler(this.onHelpAbout_Click);
            // 
            // onCharacter
            // 
            this.onCharacter.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.onCharacterNew});
            this.onCharacter.Name = "onCharacter";
            this.onCharacter.Size = new System.Drawing.Size(84, 24);
            this.onCharacter.Text = "&Character";
            // 
            // onCharacterNew
            // 
            this.onCharacterNew.Name = "onCharacterNew";
            this.onCharacterNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.onCharacterNew.Size = new System.Drawing.Size(216, 26);
            this.onCharacterNew.Text = "&New";
            this.onCharacterNew.Click += new System.EventHandler(this.onCharacterNew_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 421);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(260, 420);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Character Creator";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem onFile;
        private System.Windows.Forms.ToolStripMenuItem onFileExit;
        private System.Windows.Forms.ToolStripMenuItem onHelp;
        private System.Windows.Forms.ToolStripMenuItem onHelpAbout;
        private System.Windows.Forms.ToolStripMenuItem onCharacter;
        private System.Windows.Forms.ToolStripMenuItem onCharacterNew;
    }
}

