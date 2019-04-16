namespace ContactManager.UI
{
    partial class NewContact
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
            this.nameNewContact = new System.Windows.Forms.Label();
            this.emailNewContact = new System.Windows.Forms.Label();
            this.nameTextNewContact = new System.Windows.Forms.TextBox();
            this.emailTextNewContact = new System.Windows.Forms.TextBox();
            this.saveNewContact = new System.Windows.Forms.Button();
            this.cancelNewContact = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // nameNewContact
            // 
            this.nameNewContact.AutoSize = true;
            this.nameNewContact.Location = new System.Drawing.Point(30, 40);
            this.nameNewContact.Name = "nameNewContact";
            this.nameNewContact.Size = new System.Drawing.Size(45, 17);
            this.nameNewContact.TabIndex = 0;
            this.nameNewContact.Text = "Name";
            // 
            // emailNewContact
            // 
            this.emailNewContact.AutoSize = true;
            this.emailNewContact.Location = new System.Drawing.Point(30, 90);
            this.emailNewContact.Name = "emailNewContact";
            this.emailNewContact.Size = new System.Drawing.Size(42, 17);
            this.emailNewContact.TabIndex = 1;
            this.emailNewContact.Text = "Email";
            // 
            // nameTextNewContact
            // 
            this.nameTextNewContact.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nameTextNewContact.Location = new System.Drawing.Point(97, 37);
            this.nameTextNewContact.Name = "nameTextNewContact";
            this.nameTextNewContact.Size = new System.Drawing.Size(355, 22);
            this.nameTextNewContact.TabIndex = 2;
            this.nameTextNewContact.TextChanged += new System.EventHandler(this.nameTextNewContact_TextChanged);
            this.nameTextNewContact.Validated += new System.EventHandler(this.nameTextNewContact_TextChanged);
            // 
            // emailTextNewContact
            // 
            this.emailTextNewContact.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.emailTextNewContact.Location = new System.Drawing.Point(97, 87);
            this.emailTextNewContact.Name = "emailTextNewContact";
            this.emailTextNewContact.Size = new System.Drawing.Size(355, 22);
            this.emailTextNewContact.TabIndex = 3;
            this.emailTextNewContact.TextChanged += new System.EventHandler(this.emailTextNewContact_TextChanged);
            this.emailTextNewContact.Validated += new System.EventHandler(this.emailTextNewContact_TextChanged);
            // 
            // saveNewContact
            // 
            this.saveNewContact.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.saveNewContact.Location = new System.Drawing.Point(33, 166);
            this.saveNewContact.Name = "saveNewContact";
            this.saveNewContact.Size = new System.Drawing.Size(166, 32);
            this.saveNewContact.TabIndex = 4;
            this.saveNewContact.Text = "&Save";
            this.saveNewContact.UseVisualStyleBackColor = true;
            this.saveNewContact.Click += new System.EventHandler(this.saveNewContact_Click);
            // 
            // cancelNewContact
            // 
            this.cancelNewContact.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelNewContact.Location = new System.Drawing.Point(246, 166);
            this.cancelNewContact.Name = "cancelNewContact";
            this.cancelNewContact.Size = new System.Drawing.Size(206, 32);
            this.cancelNewContact.TabIndex = 5;
            this.cancelNewContact.Text = "&Cancel";
            this.cancelNewContact.UseVisualStyleBackColor = true;
            this.cancelNewContact.Click += new System.EventHandler(this.cancelNewContact_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // NewContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 238);
            this.ControlBox = false;
            this.Controls.Add(this.cancelNewContact);
            this.Controls.Add(this.saveNewContact);
            this.Controls.Add(this.emailTextNewContact);
            this.Controls.Add(this.nameTextNewContact);
            this.Controls.Add(this.emailNewContact);
            this.Controls.Add(this.nameNewContact);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(515, 285);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(515, 285);
            this.Name = "NewContact";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Contact";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameNewContact;
        private System.Windows.Forms.Label emailNewContact;
        private System.Windows.Forms.TextBox nameTextNewContact;
        private System.Windows.Forms.TextBox emailTextNewContact;
        private System.Windows.Forms.Button saveNewContact;
        private System.Windows.Forms.Button cancelNewContact;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}