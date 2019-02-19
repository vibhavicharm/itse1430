﻿using System;
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


            //_miGameAdd.Click += OnGameAdd; //(same thing) _miGameAdd.Click += new EventHandler(OnGameAdd);
        }

        private void OnFileExit( object sender, EventArgs e )
        {
            // Local variable
            var x = 10;

            Close();
        }

        private void OnHelpAbout( object sender, EventArgs e )
        {
            var form = new AboutBox1();
            form.ShowDialog();
        }

        private void BindList()
        {
            //Bind games for listbox
            _listGames.Items.Clear();

            _listGames.DisplayMember = nameof(Game.Name); //nameof(type name or member name) - this converts to string literal - same thing as this " nameof(Game.Name) == "Name"; "

            //_listGames.Items.AddRange(_games);
            foreach (var game in _games)
            {
                if(game != null)
                _listGames.Items.Add(game);

               
            };
        }

        private void OnGameAdd(object sender, EventArgs e)
        {
            //Display UI
            var form = new GameForm();

            // Modeless Dialoge
            //form.Show(); 
            
            // Modal dialog
            if (form.ShowDialog(this) != DialogResult.OK) // "this" represents the current instance
                return;

            //If OK then "add" to system
            _games[GetNextEmptyGame()] = form.Game;
            BindList(); // call blinlist to refresh our gamelist
        }
        
        //HACK: Find first spot in array with no games
        private int GetNextEmptyGame()
        {
            for(var index = 0; index < _games.Length; index++)
            {
                if (_games[index] == null)
                    return index;
   
            }
            return -1; // because it is an invalid index we return -1
        }


        private void OnGameEdit( object sender, EventArgs e )
        {                       
            var form = new GameForm();

            var game = GetSelectedGame();
            if (game == null)
                return;

            // Game to edit
            form.Game = game;

            if (form.ShowDialog(this) != DialogResult.OK)
                return;

            //TODO: fix to edit, not add
            UpdateGame(game, form.Game);
            BindList();
        }

        private void UpdateGame( Game oldGame, Game newGame )
        {
            for (var index = 0; index < _games.Length; ++index)
            {
                if (_games[index] == oldGame)
                {
                    _games[index] = newGame;
                    break;
                };
            };
        }


        private void OnGameDelete( object sender, EventArgs e )
        {
            // Get selected game, if any
            var selected = GetSelectedGame();
            if (selected == null)
                return;

            // Dispaly confirmation
            if(MessageBox.Show($"Are you sure you want to delete {selected.Name}?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes);
            return;

            //TODO: Delete
            DeleteGame(selected);
            BindList();

        }

        private void DeleteGame( Game game )
        {
            for (var index = 0; index < _games.Length; ++index)
            {
                if (_games[index] == game)
                {
                    _games[index] = null;
                    break;
                };
            };
        }

        private Game GetSelectedGame()
        {
            var value = _listGames.SelectedItem;

            //C-style cast - don't do this
            //var game = (Game)value;

            //Preferred - null if not valid
            var game = value as Game; // "as" operator

            //Type check
            var game2 = (value is Game) ? (Game)value : null; //"is" operator

            return _listGames.SelectedItem as Game;
        }



        private Game[] _games = new Game[100];

        //List box has a selected index and in those index they have selected items
        //this case list box was selected. we can talk about objects more in this case
        private void OnGameSelected( object sender, EventArgs e )
        {

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
 */

/* February 13, 2019
 * Show Dialog is modal dailog. Until you cancel the child dialog you cannot go back to parent dialog.
 * Modeless windows are viseversa of modal dialog. You can do what ever you want to parent dialog when the child dialoge is open.
 * 1) child form - we want show this form to compiler. type is FileDialog, if OK call function Do work:
 *  var FileDialog = new FileDialog();
 *  if(FileDialog.ShowDialoge() == DialogResult.OK){
 *      DoWork();
 *  }
 * 2) Hookup on sendMail to send event of mail:
 *  mail.send += OnSemd<ail;
 */

/* February 18, 2019
 * Delegate - Function object
 * Return types and parameters are important
 * fuctions can match to defferent types
 * event EventHandler click - definition for event handler (EventHandler is the type)
 * (object sender, EventArgs e) - definition of event handler; sender is the first parameter. second parameter always e.
 * CancelEventArgs() are the only event handlers that has both get and set properties
 * we always use void for these events
 *  pass by value and passe by reference;
 *  pass by Value types can never be null
 *  pass by reference types can be null
 *  value types are immutable but reference types are mutable
 *  if it is a struct it is a value type, if it is a class type it is a reference type - this is only for c#. 
 */