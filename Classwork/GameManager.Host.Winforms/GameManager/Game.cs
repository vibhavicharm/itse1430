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
        public string Name;
        public string Publlisher;
        public decimal Price;
        public bool Owned;
        public bool Completed;
    }
}

/* February 4, 2019 - Classes
 * every member of class has an accessibility(visibility) in own class
 * public accessibility means everybody. if a member is public it is visible for everybody
 * rectangular select - search this. Be very careful with string literals
 * private - type only (defalt for members)
 * classes are accessibility when they are public 
 * if you didnot modify access modifier this means its internal - assembly only
 * internal - defalt for types
 * Class;
 *  they are nouns - noun based
 *  always pascal case
 *  public types and public members are reuired to comments in the labs use <summery> tabs - type /// then studio automatically adds these
 * 
 */
