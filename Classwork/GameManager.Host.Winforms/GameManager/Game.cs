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
        /// <summary> Name of the game </summary>
        public string Name = "";

        public string Publlisher = ""; 
        public decimal Price;
        public bool Owned;
        public bool Completed;

        // public string[] genres = new string [10] - you can do this as welas an array

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

/* February 6, 2019
 * initializers cannot (reference)be defined by any member of this type - "private decimal realPrice = Price" is wrong. you cannot do it. and language doeds not allowed it
 * 
 * 
 */
