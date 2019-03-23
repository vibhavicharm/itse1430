/* Vibhavi Jayasinghe
 * Lab2
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharacterCreator.Winforms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void onFileExit_Click( object sender, EventArgs e )
        {
            Close();
        }

        private void onHelpAbout_Click( object sender, EventArgs e )
        {
            var form = new AboutBox1();
            form.ShowDialog();
        }

        private void onCharacterNew_Click( object sender, EventArgs e )
        {
            var form = new NewCharacterForm();
            form.StartPosition = FormStartPosition.CenterParent;
            form.Show(this);
        }
    }
}
