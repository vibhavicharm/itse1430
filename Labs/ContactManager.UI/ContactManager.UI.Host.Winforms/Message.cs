using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactManager.UI.Host.Winforms
{
    public partial class newMessageForm : Form
    {
        public newMessageForm()
        {
            InitializeComponent();
        }

        public Message Message { get; set; }


        private void newMessageForm_Load( object sender, EventArgs e )
        {

        }

        private void nameTextMessageNew_TextChanged( object sender, EventArgs e )
        {
            if (string.IsNullOrEmpty(nameTextMessageNew.Text))
            {
                errorProvider1.SetError(nameTextMessageNew, "Contact is required");
            } else
            {
                errorProvider1.SetError(nameTextMessageNew, null);
            }
        }

        private void emailTextMessageNew_TextChanged( object sender, EventArgs e )
        {
            if (string.IsNullOrEmpty(emailTextMessageNew.Text))
            {
                errorProvider1.SetError(emailTextMessageNew, "Contact is required");
            } else
            {
                errorProvider1.SetError(emailTextMessageNew, null);
            }
        }

        
    }
}
