namespace ContactManager.UI.Host.Winforms
{
    partial class newMessageForm
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
            this.nameMessageNew = new System.Windows.Forms.Label();
            this.emailMessageNew = new System.Windows.Forms.Label();
            this.nameTextMessageNew = new System.Windows.Forms.TextBox();
            this.emailTextMessageNew = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // nameMessageNew
            // 
            this.nameMessageNew.AutoSize = true;
            this.nameMessageNew.Location = new System.Drawing.Point(61, 57);
            this.nameMessageNew.Name = "nameMessageNew";
            this.nameMessageNew.Size = new System.Drawing.Size(45, 17);
            this.nameMessageNew.TabIndex = 3;
            this.nameMessageNew.Text = "Name";
            // 
            // emailMessageNew
            // 
            this.emailMessageNew.AutoSize = true;
            this.emailMessageNew.Location = new System.Drawing.Point(61, 124);
            this.emailMessageNew.Name = "emailMessageNew";
            this.emailMessageNew.Size = new System.Drawing.Size(42, 17);
            this.emailMessageNew.TabIndex = 4;
            this.emailMessageNew.Text = "Email";
            // 
            // nameTextMessageNew
            // 
            this.nameTextMessageNew.Location = new System.Drawing.Point(223, 54);
            this.nameTextMessageNew.Name = "nameTextMessageNew";
            this.nameTextMessageNew.Size = new System.Drawing.Size(466, 22);
            this.nameTextMessageNew.TabIndex = 0;
            this.nameTextMessageNew.TextChanged += new System.EventHandler(this.nameTextMessageNew_TextChanged);
            this.nameTextMessageNew.Validated += new System.EventHandler(this.nameTextMessageNew_TextChanged);
            // 
            // emailTextMessageNew
            // 
            this.emailTextMessageNew.Location = new System.Drawing.Point(223, 119);
            this.emailTextMessageNew.Name = "emailTextMessageNew";
            this.emailTextMessageNew.Size = new System.Drawing.Size(466, 22);
            this.emailTextMessageNew.TabIndex = 1;
            this.emailTextMessageNew.TextChanged += new System.EventHandler(this.emailTextMessageNew_TextChanged);
            this.emailTextMessageNew.Validated += new System.EventHandler(this.emailTextMessageNew_TextChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // newMessageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.emailTextMessageNew);
            this.Controls.Add(this.nameTextMessageNew);
            this.Controls.Add(this.emailMessageNew);
            this.Controls.Add(this.nameMessageNew);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "newMessageForm";
            this.Text = "Message";
            this.Load += new System.EventHandler(this.newMessageForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameMessageNew;
        private System.Windows.Forms.Label emailMessageNew;
        private System.Windows.Forms.TextBox nameTextMessageNew;
        private System.Windows.Forms.TextBox emailTextMessageNew;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

