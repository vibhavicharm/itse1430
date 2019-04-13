using System;
using System.Windows.Forms;

namespace ContactManager.UI
{
    public partial class NewContact : Form
    {
        public NewContact()
        {
            InitializeComponent();
        }

        public Contact contact { get; set; }
        public object Contact { get; private set; }

        private void nameTextNewContact_TextChanged( object sender, EventArgs e )
        {
            if (string.IsNullOrEmpty(nameTextNewContact.Text))
            {
                errorProvider1.SetError(nameTextNewContact, "Name is required");
            } else
            {
                errorProvider1.SetError(nameTextNewContact, null);
            }
        }

        private void emailTextNewContact_TextChanged( object sender, EventArgs e )
        {
            if (string.IsNullOrEmpty(emailTextNewContact.Text))
            {
                errorProvider1.SetError(emailTextNewContact, "Email is required");
            } else
            {
                errorProvider1.SetError(emailTextNewContact, null);
            }
        }

        private void saveNewContact_Click( object sender, EventArgs e )
        {
            if (!ValidateChildren())
                return;

            var contact = SaveDataNew();

            MessageBox.Show(this, "Contact not valid.", "Error", MessageBoxButtons.OK);
            return;


            Contact = contact;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void cancelNewContact_Click( object sender, EventArgs e )
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void LoadData( Contact contact )
        {
            nameTextNewContact.Text = contact.Name;
            emailTextNewContact.Text = contact.Email;
        }

        //Saves UI into new game
        private Contact SaveDataNew()
        {
            var contact = new Contact();
            contact.Name = nameTextNewContact.Text;
            contact.Email = emailTextNewContact.Text;
            
            return contact;
        }

        protected override void OnLoad( EventArgs e )
        {
            //this.OnLoad(e);
            base.OnLoad(e);

            //Init UI if editing a game
            if (Contact != null)
                LoadData(Contact);

            ValidateChildren();
        }

        private void LoadData( object contact )
        {
            throw new NotImplementedException();
        }
    }
}
