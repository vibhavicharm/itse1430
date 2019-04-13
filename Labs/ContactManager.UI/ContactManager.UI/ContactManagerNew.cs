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
        public object GetContact { get; private set; }

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
        {}

        private void emailTextContacts_TextChanged( object sender, EventArgs e )
        {}

        private void newToolStripMenuItem_Click( object sender, EventArgs e )
        {}

        private void menuContactAdd_Click( object sender, EventArgs e )
        {
            var form = new NewContact();
            form.Show();

            while (false)
            {
                // Modal dialog
                if (form.ShowDialog(this) != DialogResult.OK)
                    return;

                //Add
                try
                {
                    OnSafeAdd(form);
                    break;
                } catch (InvalidOperationException)
                {
                    MessageBox.Show(this, "Choose a better game.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } catch (Exception ex)
                {
                    //Recover from errors
                    DisplayError(ex);
                };
            };

            BindList();

        }

        private void DisplayError( Exception ex )
        {
            MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void OnSafeAdd( NewContact form )
        {
            try
            {
                //_games[GetNextEmptyGame()] = form.Game;
                _contacts.Add(form.Contact);
            } catch (NotImplementedException e)
            {
                //Rewriting an exception
                throw new Exception("Not implemented yet", e);
            } catch (Exception e)
            {
                throw;
            };
        }

        private void BindList()
        {
            //Bind games to listbox
            _listContacts.Items.Clear();
            _listContacts.DisplayMember = nameof(Contact.Name);

            var items = _contacts.GetAll();
            items = items.OrderBy(GetName);
            _listContacts.Items.AddRange(items.ToArray());

        }

        private string GetName( Contact contact )
        {
            return contact.Name;
        }

        private IContactDatabaseNew _contacts;

        private void _listContacts_SelectedIndexChanged( object sender, EventArgs e )
        {

        }

        private void sendToolStripMenuItem_Click( object sender, EventArgs e )
        {
            var form = new sendMessageForm();
            form.Show();
        }
    }
}
