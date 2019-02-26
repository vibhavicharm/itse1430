using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameManager
{
    /// <summary> Represents a game </summary>
    public class Game
    {
        //Default, no return type 
        //Default constaructor has no parameters
        public Game()
        {
            //Complex init
            var x = 1 + 2;

        }

        //Constructor chaining
        public Game(string name ) : this(name, 0) // : is a seperator in here. constructor with two parameters. so it calles the other constructor with two parameters. so then that constructor executes
        {
            //Name = name;
        }

        //As soon as you define a constructor, no defaulat ctor anymore
        public Game(string name, decimal price )
        {
            Name = name;
            Price = price;
        }

        /// <summary> Name of the game </summary>
        public string Name {
            get { return _name ?? ""; } // keywords inside the property declaration. must return the value you get. (read)
            set { _name = value; } // write
        }
        // name guranteed never to be null

        private string _name = ""; // standard convention for fields(underscore and camalcase)



        public string Publlisher {
            get { return _publisher ?? ""; } // they would not return null
            set { _publisher = value; }
        }


        // Calculated property
        public bool IsCoolGame {
            get { return _publisher != "EA"; } // properties can be calulated properties
        }

        private string _publisher = ""; // properties do not have data

        public decimal Price
        {
            get { return _price; }
            set { _price = value; }
        }

        private decimal _price;

        public bool Owned;
        public bool Completed;

        // Mixed accessibility
        public double Rate
        {
            get;
            internal set;
        }

        public void Foo()
        {
            //NOT DETERMINISTIC - should have been a method
            var now = DateTime.Now; // time is always changing. 
        }
        //*** if theere is a side effect in property it should be a method - system caching (method calls cache the value)

        public override string ToString()
        {
            return Name;
        }

        //Can init the data as well
        // Don't use array properties because they require cloning and are inefficient
        //public string[] Genres { get; set; } 
        public string[] Genres
        {
            get
            {
                var temp = new string[_genres.Length];
                Array.Copy(_genres, temp, _genres.Length);
                return temp;
            }
        }
        private string[] _genres;


        //public string[] genres = new string[10]; - you can do this as well as an array
        //private decimal realPrice = Price;

        /// <summary>Validates the object</summary>
        /// <returns></returns>
        public bool Validate(/* Game this */) // always comes this. this is always there. "this" word passes the instance
        {
            //Redundant dude
            //var str = this.Name; //you dont want to declare it bacuse it is always there.

            // Name is required
            if(String.IsNullOrEmpty(Name)){
                return false;
            }

            // Price >= 0
            if(Price < 0)
            {
                return false;
            }

            //Only if you need to pass the instance to somebody else
            //MyType.Foo(this);

            return true;
        }

    }
}

/* February 4, 2019 - Classes
 * every member of class has an accessibility(visibility) in own class
 * public accessibility means everybody. if a member is public it is visible for everybody
 * rectangular select - search this. Be very careful with string literals
 * private - type only (defalt for members)
 * classes are accessibility when they are public 
 * if you didnot modify access modifier this means its internal - assembly only
 * internal - defalt for types - public to assembly and private to everyone else
 * Class;
 *  they are nouns - noun based
 *  always pascal case
 *  public types and public members are reuired to comments in the labs use <summery> tabs - type /// then studio automatically adds these
 */

/* February 6, 2019, February 11, 2019 - Fields, Methods and Properties
 * initializers cannot (reference)be defined by any member of this type - "private decimal realPrice = Price" is wrong. you cannot do it. and language doeds not allowed it
 * Properties:
 * uses the syntax of filed this is properties
 * process.GetProcess() helps to process
 * properties are called repeatedly, they are fastest fields
 * properties are design for look an d behave like fields
 * Coalesce(expression, expression, expression) - takes two expressions and its evaluate the left expression. and first one is not empty.
 * Auto property
   public decimal Price { get; set; } //the auto property the syntax is not needed
 */

/* February 13, 2019
 * Polling is you waiting and refresh again and again. Events handles the polling.
 * Polling - You are awaiting for something to happen. 
 * Event has two questions. what and who
 * Events-
 *   what : control
 *   who : method
 */