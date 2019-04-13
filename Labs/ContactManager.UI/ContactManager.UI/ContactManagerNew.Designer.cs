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
            this.menuContact = new System.Windows.Forms.ToolStripMenuItem();
            this.menuContactAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this._listContacts = new System.Windows.Forms.ListBox();
            this.sendToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuContactDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.menuContactEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuContact,
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
            this.menuHelpAbout.Size = new System.Drawing.Size(149, 26);
            this.menuHelpAbout.Text = "About";
            this.menuHelpAbout.Click += new System.EventHandler(this.menuHelpAbout_Click);
            // 
            // menuContact
            // 
            this.menuContact.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuContactAdd,
            this.sendToolStripMenuItem,
            this.menuContactEdit,
            this.menuContactDelete});
            this.menuContact.Name = "menuContact";
            this.menuContact.Size = new System.Drawing.Size(72, 24);
            this.menuContact.Text = "Contact";
            // 
            // menuContactAdd
            // 
            this.menuContactAdd.Name = "menuContactAdd";
            this.menuContactAdd.ShortcutKeys = System.Windows.Forms.Keys.Insert;
            this.menuContactAdd.Size = new System.Drawing.Size(216, 26);
            this.menuContactAdd.Text = "Add";
            this.menuContactAdd.Click += new System.EventHandler(this.menuContactAdd_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // _listContacts
            // 
            this._listContacts.BackColor = System.Drawing.SystemColors.MenuBar;
            this._listContacts.FormattingEnabled = true;
            this._listContacts.ItemHeight = 16;
            this._listContacts.Location = new System.Drawing.Point(0, 31);
            this._listContacts.Name = "_listContacts";
            this._listContacts.Size = new System.Drawing.Size(481, 324);
            this._listContacts.TabIndex = 3;
            this._listContacts.SelectedIndexChanged += new System.EventHandler(this._listContacts_SelectedIndexChanged);
            // 
            // sendToolStripMenuItem
            // 
            this.sendToolStripMenuItem.Name = "sendToolStripMenuItem";
            this.sendToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.sendToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.sendToolStripMenuItem.Text = "Send";
            this.sendToolStripMenuItem.Click += new System.EventHandler(this.sendToolStripMenuItem_Click);
            // 
            // menuContactDelete
            // 
            this.menuContactDelete.Name = "menuContactDelete";
            this.menuContactDelete.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.menuContactDelete.Size = new System.Drawing.Size(216, 26);
            this.menuContactDelete.Text = "Delete";
            this.menuContactDelete.Click += new System.EventHandler(this.menuContactDelete_Click);
            // 
            // menuContactEdit
            // 
            this.menuContactEdit.Name = "menuContactEdit";
            this.menuContactEdit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.menuContactEdit.Size = new System.Drawing.Size(216, 26);
            this.menuContactEdit.Text = "Edit";
            this.menuContactEdit.Click += new System.EventHandler(this.menuContactEdit_Click);
            // 
            // ContactsMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 353);
            this.Controls.Add(this._listContacts);
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
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolStripMenuItem menuContact;
        private System.Windows.Forms.ToolStripMenuItem menuContactAdd;
        private System.Windows.Forms.ListBox _listContacts;
        private System.Windows.Forms.ToolStripMenuItem sendToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuContactDelete;
        private System.Windows.Forms.ToolStripMenuItem menuContactEdit;
    }
}

