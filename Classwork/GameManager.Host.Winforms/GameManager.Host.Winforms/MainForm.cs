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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            LoadUI();
        }

        void LoadUI()
        {
            Game game = new Game();

            game.Name = "DOOM";
            game.Price = 59.99M; // you cannot convert double or float to a decimal. Use capital "M" at the end. M stands for money

            var name = game.Name;

            if (name.Length == 0) 
                /* is empty */;
            if (game.Name.Length == 0) // properties behave just like fileds
                /* is empty */
                ;

            //Validate(game);
            game.Validate(); //go to game class and then go to validate method and checks if the game is valid or not

            //var x = 10;
            //x.ToString();

            //Decimal.TryParse("45.99", out game.Price); // we do not nead to declare because we already done it when we make the game class

        }

        private void OnFileExit( object sender, EventArgs e )
        {
            // Local variable
            var x = 10;

            Close();
        }

        private void OnHelpAbout( object sender, EventArgs e )
        {
            MessageBox.Show("Help");
        }

        private void OnGameAdd(object sender, EventArgs e)
        {
            //Display UI

            //If OK then "add" to system
        }
    }
}

/* February 4, 2019
 * new means initiating new instance and an object
 * clases are allow us to hide everything else
 * instance.member - "." is member operator or field operator. member of same type of instance
 */

/* February 6, 2019, February 11, 2019
 * field 
 * functiona names always are verbs - pascal casing
 * for methods also pascal caseing
 * fields always private - if there is public fields in Lab you will loose points
 * 
 */
