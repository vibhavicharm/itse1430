namespace ContactManager.UI
{
    partial class sendMessageForm
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
            this.sendMessageNameText = new System.Windows.Forms.TextBox();
            this.sendMessageTextSubject = new System.Windows.Forms.TextBox();
            this.sendMessageTextMessage = new System.Windows.Forms.TextBox();
            this.sendMessageName = new System.Windows.Forms.Label();
            this.sendMessageSubject = new System.Windows.Forms.Label();
            this.sendMessageMessage = new System.Windows.Forms.Label();
            this.sendMessageSend = new System.Windows.Forms.Button();
            this.sendMessageCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sendMessageNameText
            // 
            this.sendMessageNameText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sendMessageNameText.Location = new System.Drawing.Point(151, 34);
            this.sendMessageNameText.Name = "sendMessageNameText";
            this.sendMessageNameText.Size = new System.Drawing.Size(368, 22);
            this.sendMessageNameText.TabIndex = 3;
            // 
            // sendMessageTextSubject
            // 
            this.sendMessageTextSubject.Location = new System.Drawing.Point(151, 83);
            this.sendMessageTextSubject.Name = "sendMessageTextSubject";
            this.sendMessageTextSubject.Size = new System.Drawing.Size(368, 22);
            this.sendMessageTextSubject.TabIndex = 4;
            // 
            // sendMessageTextMessage
            // 
            this.sendMessageTextMessage.Location = new System.Drawing.Point(151, 134);
            this.sendMessageTextMessage.Multiline = true;
            this.sendMessageTextMessage.Name = "sendMessageTextMessage";
            this.sendMessageTextMessage.Size = new System.Drawing.Size(368, 86);
            this.sendMessageTextMessage.TabIndex = 5;
            // 
            // sendMessageName
            // 
            this.sendMessageName.AutoSize = true;
            this.sendMessageName.Location = new System.Drawing.Point(36, 37);
            this.sendMessageName.Name = "sendMessageName";
            this.sendMessageName.Size = new System.Drawing.Size(97, 17);
            this.sendMessageName.TabIndex = 6;
            this.sendMessageName.Text = "Contact Name";
            // 
            // sendMessageSubject
            // 
            this.sendMessageSubject.AutoSize = true;
            this.sendMessageSubject.Location = new System.Drawing.Point(78, 86);
            this.sendMessageSubject.Name = "sendMessageSubject";
            this.sendMessageSubject.Size = new System.Drawing.Size(55, 17);
            this.sendMessageSubject.TabIndex = 7;
            this.sendMessageSubject.Text = "Subject";
            // 
            // sendMessageMessage
            // 
            this.sendMessageMessage.AutoSize = true;
            this.sendMessageMessage.Location = new System.Drawing.Point(68, 137);
            this.sendMessageMessage.Name = "sendMessageMessage";
            this.sendMessageMessage.Size = new System.Drawing.Size(65, 17);
            this.sendMessageMessage.TabIndex = 8;
            this.sendMessageMessage.Text = "Message";
            // 
            // sendMessageSend
            // 
            this.sendMessageSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sendMessageSend.Location = new System.Drawing.Point(151, 242);
            this.sendMessageSend.Name = "sendMessageSend";
            this.sendMessageSend.Size = new System.Drawing.Size(151, 34);
            this.sendMessageSend.TabIndex = 9;
            this.sendMessageSend.Text = "&Send";
            this.sendMessageSend.UseVisualStyleBackColor = true;
            this.sendMessageSend.Click += new System.EventHandler(this.sendMessageSend_Click);
            // 
            // sendMessageCancel
            // 
            this.sendMessageCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sendMessageCancel.Location = new System.Drawing.Point(368, 242);
            this.sendMessageCancel.Name = "sendMessageCancel";
            this.sendMessageCancel.Size = new System.Drawing.Size(151, 34);
            this.sendMessageCancel.TabIndex = 10;
            this.sendMessageCancel.Text = "&Cancel";
            this.sendMessageCancel.UseVisualStyleBackColor = true;
            this.sendMessageCancel.Click += new System.EventHandler(this.sendMessageCancel_Click);
            // 
            // sendMessageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 299);
            this.ControlBox = false;
            this.Controls.Add(this.sendMessageCancel);
            this.Controls.Add(this.sendMessageSend);
            this.Controls.Add(this.sendMessageMessage);
            this.Controls.Add(this.sendMessageSubject);
            this.Controls.Add(this.sendMessageName);
            this.Controls.Add(this.sendMessageTextMessage);
            this.Controls.Add(this.sendMessageTextSubject);
            this.Controls.Add(this.sendMessageNameText);
            this.MaximumSize = new System.Drawing.Size(587, 346);
            this.MinimumSize = new System.Drawing.Size(587, 346);
            this.Name = "sendMessageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Send a Message";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox sendMessageNameText;
        private System.Windows.Forms.TextBox sendMessageTextSubject;
        private System.Windows.Forms.TextBox sendMessageTextMessage;
        private System.Windows.Forms.Label sendMessageName;
        private System.Windows.Forms.Label sendMessageSubject;
        private System.Windows.Forms.Label sendMessageMessage;
        private System.Windows.Forms.Button sendMessageSend;
        private System.Windows.Forms.Button sendMessageCancel;
    }
}