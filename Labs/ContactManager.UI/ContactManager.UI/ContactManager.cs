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
    public partial class ContactsMainForm : Form
    {
        public ContactsMainForm()
        {
            InitializeComponent();
        }

        public ContactsMainForm Contact { get; set; }

        private void exitToolStripMenuItem_Click( object sender, EventArgs e )
        {
            Close();
        }

        private void menuHelpAbout_Click( object sender, EventArgs e )
        {
            var form = new AboutBox1();
            form.Show();
        }

        private void ContactsMainForm_Load( object sender, EventArgs e )
        {

        }

        private void nameTextContacts_Validating( object sender, CancelEventArgs e )
        {

        }

        private void nameTextContacts_TextChanged( object sender, EventArgs e )
        {

            if (string.IsNullOrEmpty(nameTextContacts.Text))
            {
                errorProvider1.SetError(nameTextContacts, "Name is required");
            } else
            {
                errorProvider1.SetError(nameTextContacts, null);
            }
        }

        private void emailTextContacts_TextChanged( object sender, EventArgs e )
        {
            if (string.IsNullOrEmpty(emailTextContacts.Text))
            {
                errorProvider1.SetError(emailTextContacts, "Email is required");
            } else
            {
                errorProvider1.SetError(emailTextContacts, null);
            }
        }

        
    }
}
