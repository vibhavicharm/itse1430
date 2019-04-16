namespace ContactManager.UI
{
    partial class ContactsMainForm
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.nameContacts = new System.Windows.Forms.Label();
            this.emailContacts = new System.Windows.Forms.Label();
            this.nameTextContacts = new System.Windows.Forms.TextBox();
            this.emailTextContacts = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(482, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFileExit});
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(44, 24);
            this.menuFile.Text = "File";
            // 
            // menuFileExit
            // 
            this.menuFileExit.Name = "menuFileExit";
            this.menuFileExit.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.menuFileExit.Size = new System.Drawing.Size(132, 26);
            this.menuFileExit.Text = "Exit";
            this.menuFileExit.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // menuHelp
            // 
            this.menuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuHelpAbout});
            this.menuHelp.Name = "menuHelp";
            this.menuHelp.Size = new System.Drawing.Size(53, 24);
            this.menuHelp.Text = "Help";
            // 
            // menuHelpAbout
            // 
            this.menuHelpAbout.Name = "menuHelpAbout";
            this.menuHelpAbout.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.menuHelpAbout.Size = new System.Drawing.Size(216, 26);
            this.menuHelpAbout.Text = "About";
            this.menuHelpAbout.Click += new System.EventHandler(this.menuHelpAbout_Click);
            // 
            // nameContacts
            // 
            this.nameContacts.AutoSize = true;
            this.nameContacts.Location = new System.Drawing.Point(51, 88);
            this.nameContacts.Name = "nameContacts";
            this.nameContacts.Size = new System.Drawing.Size(45, 17);
            this.nameContacts.TabIndex = 3;
            this.nameContacts.Text = "Name";
            // 
            // emailContacts
            // 
            this.emailContacts.AutoSize = true;
            this.emailContacts.Location = new System.Drawing.Point(51, 131);
            this.emailContacts.Name = "emailContacts";
            this.emailContacts.Size = new System.Drawing.Size(42, 17);
            this.emailContacts.TabIndex = 4;
            this.emailContacts.Text = "Email";
            // 
            // nameTextContacts
            // 
            this.nameTextContacts.Location = new System.Drawing.Point(136, 85);
            this.nameTextContacts.Name = "nameTextContacts";
            this.nameTextContacts.Size = new System.Drawing.Size(287, 22);
            this.nameTextContacts.TabIndex = 0;
            this.nameTextContacts.Click += new System.EventHandler(this.nameTextContacts_TextChanged);
            this.nameTextContacts.TabStopChanged += new System.EventHandler(this.ContactsMainForm_Load);
            this.nameTextContacts.TextChanged += new System.EventHandler(this.nameTextContacts_TextChanged);
            this.nameTextContacts.Validating += new System.ComponentModel.CancelEventHandler(this.nameTextContacts_Validating);
            this.nameTextContacts.Validated += new System.EventHandler(this.nameTextContacts_TextChanged);
            // 
            // emailTextContacts
            // 
            this.emailTextContacts.Location = new System.Drawing.Point(136, 131);
            this.emailTextContacts.Name = "emailTextContacts";
            this.emailTextContacts.Size = new System.Drawing.Size(287, 22);
            this.emailTextContacts.TabIndex = 1;
            this.emailTextContacts.TextChanged += new System.EventHandler(this.emailTextContacts_TextChanged);
            this.emailTextContacts.Validated += new System.EventHandler(this.emailTextContacts_TextChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ContactsMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 353);
            this.Controls.Add(this.emailTextContacts);
            this.Controls.Add(this.nameTextContacts);
            this.Controls.Add(this.emailContacts);
            this.Controls.Add(this.nameContacts);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(500, 400);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(500, 400);
            this.Name = "ContactsMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contacts";
            this.Load += new System.EventHandler(this.ContactsMainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem menuFileExit;
        private System.Windows.Forms.ToolStripMenuItem menuHelp;
        private System.Windows.Forms.ToolStripMenuItem menuHelpAbout;
        private System.Windows.Forms.Label nameContacts;
        private System.Windows.Forms.Label emailContacts;
        private System.Windows.Forms.TextBox nameTextContacts;
        private System.Windows.Forms.TextBox emailTextContacts;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

