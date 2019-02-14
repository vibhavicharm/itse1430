using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameManager.Host.Winforms
{
    public partial class GameForm : Form
    {
        public GameForm()
        {
            InitializeComponent();
        }

        public Game Game { get; set; }

        private void OnSave( object sender, EventArgs e )
        {
            Game = SaveData();
            DialogResult = DialogResult.OK; // DialogResult is an enum. syntax for enum is "enum = enum.type"

            Close();
            
        }

        private void OnCancel( object sender, EventArgs e )
        {
            DialogResult = DialogResult.Cancel;

            Close();
        }

        private decimal ReadDecimal(TextBox control )
        {
            if (Decimal.TryParse(control.Text, out var value))
                return value;

            return -1;
        }

        private void LoadData(Game game )
        {
            _txtName.Text = game.Name;
            _txtPublisher.Text = game.Publlisher;
            _txtPrice.Text = game.Price.ToString();
            _cbOwned.Checked = game.Owned;
            _cbCompleted.Checked = game.Completed;
        }

        // Saves UI into new game
        private Game SaveData()
        {
            var game = new Game();
            game.Name = _txtName.Text;
            game.Publlisher = _txtPrice.Text;
            game.Price = ReadDecimal(_txtPrice);
            game.Owned = _cbOwned.Checked; //check boxes have a checked property. it is a boolian
            game.Completed = _cbCompleted.Checked;

            return game;
        }

        private void textBox2_TextChanged( object sender, EventArgs e )
        {

        }

        private void GameForm_Load( object sender, EventArgs e )
        {
            // Unit UI if editing a game
            if (Game != null)// this is where you initialize the UI
                LoadData(Game);
        }
    }
}
