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

        }
    }
}

/* February 4, 2019
 * new means initiating new instance and an object
 * clases are allow us to hide everything else
 * instance.member - "." is member operator or field operator. member of same type of instance
 * 
 */
