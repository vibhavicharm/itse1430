using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactManager.UI
{
    public partial class sendMessageForm : Form
    {
        public sendMessageForm()
        {
            InitializeComponent();
        }

        public Contact contact { get; set; }

        private void sendMessageCancel_Click( object sender, EventArgs e )
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void sendMessageSend_Click( object sender, EventArgs e )
        {
            if (!ValidateChildren())
                return;

            var contact = SaveData();

            MessageBox.Show(this, "Contact not valid.", "Error", MessageBoxButtons.OK);
            return;
        }

        private Contact SaveData()
        {
            var contact = new Contact();
            contact.Name = sendMessageNameText.Text;
            contact.Email = sendMessageTextSubject.Text;

            return contact;
        }

        private void sendMessageTextSubject_TextChanged( object sender, EventArgs e )
        {
            if (string.IsNullOrEmpty(sendMessageTextSubject.Text))
            {
                errorProvider1.SetError(sendMessageTextSubject, "Name is required");
            } else
            {
                errorProvider1.SetError(sendMessageTextSubject, null);
            }
        }
    }
}
