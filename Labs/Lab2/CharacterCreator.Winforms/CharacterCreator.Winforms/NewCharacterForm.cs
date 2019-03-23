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
    public partial class NewCharacterForm : Form
    {
        public NewCharacterForm()
        {
            InitializeComponent();
        }

        public NewCharacterForm NewCharacter { get; set; }

        private void OnNewCharaDescription_Click( object sender, EventArgs e )
        {

        }

        private void label5_Click( object sender, EventArgs e )
        {

        }

        private void OnNewCharaName_Click( object sender, EventArgs e )
        {

        }

        private void onNewCharaSave_Click( object sender, EventArgs e )
        {
            if (ValidateChildren())
            {
                var character = onNewCharaSave;

                MessageBox.Show(this, "Game not valid.", "Error", MessageBoxButtons.OK);
                return;
            };
        }

        

        private void onNewCharaProfessionComboBox_SelectedIndexChanged( object sender, EventArgs e )
        {
            
        }

        private void onNewCharaCancel_Click( object sender, EventArgs e )
        {
            DialogResult = DialogResult.Cancel;

            Close();
        }

        private void DisplayError( Exception ex )
        {
            MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void onNewCharaNameTextBox_TextChanged( object sender, EventArgs e, Exception ex)
        {
            if(onNewCharaNameTextBox.TextLength < 0)
            {
                DisplayError(ex);
            }
        }

        private void onNewCharaNameTextBox_TextChanged( object sender, EventArgs e )
        {

        }

        private void OnValidateName( object sender, CancelEventArgs e )
        {
            var tb = sender as TextBox;

            if (tb.Text.Length == 0)
            {
                //_error.SetError(tb, "Name is required.");
                e.Cancel = true;
                //MessageBox.Show("Name is required", "error", MessageBoxButtons.OK);
            } else
            {
                //_errors.SetError(tb, "");
            }
        }
    }
}
