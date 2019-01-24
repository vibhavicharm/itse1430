/*
 * Lab 1 (Lab number)
 * Vibhavi Jayasinghe (Your name)
 */
 // You must have a file header in every lab assignments  
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main( string[] args )
        {
            NewGame();
            DisplayGame();

        }

        //first lab day. this function only has csharp basics. Asks the name and say hello with the user's given name
        private static void CSharpBasics()
        {
            string name;
            int hours = 8; //8L for long
            //double payRate = 8.25; //8.25 for Float


            Console.WriteLine(hours);

            Console.WriteLine("Enter your name: ");
            name = Console.ReadLine(); //assignning; variable = expression(they are must be same type)

            //string message = "Hello " + name; // this is working too in c#
            Console.Write("Hello ");
            Console.WriteLine(name);
        }

        //new game function. if we need to make game file to 
        private static void NewGame()
        {
            Console.WriteLine("Enter the name: ");
            name = Console.ReadLine(); // no parameters and rrturn the string whatever user entered

            Console.WriteLine("Do you own this? ");
            //string owned = Console.ReadLine();
            owned = ReadBoolean("Owned (Y/N)?");

            //Console.WriteLine("Price? ");
            //string price = Console.ReadLine();
            price = ReadDecimal("Price?");

            Console.WriteLine("Publisher: ");
            publisher = Console.ReadLine();

            //Console.WriteLine("Completed? ");
            //string completed = Console.ReadLine();
            completed = ReadBoolean("Completed (Y/N)?");
        }

        private static void DisplayGame()
        {
            string literall = "Hello \"Ashu\""; // \t is tab, \" shows \\ in console
            string path = "C:\\Windows\\System32";// those \\ are just one when console
            string path2 = @"C:\Windows\System32"; //verbatim string is an escape sequence

            Console.WriteLine("Name: " + name);
            Console.WriteLine("Price: " + price);
            Console.WriteLine("Publisher: " + publisher);
            Console.WriteLine("Owned? " + owned);
            Console.WriteLine("Completed? " + completed);
        }

        private static bool ReadBoolean(string message)
        {
            Console.WriteLine(message);
            string result = Console.ReadLine();

            //validate it is a boolean
            //TODO: Fix this expression 
            //these shows in task list as TODO
            if (result == "Y")
                return true;
            if (result == "y")
                return true;
            if (result == "N")
                return false;
            if (result == "n")
                return false;

            //TODO: Add validation 
            return false; 
        }

        private static decimal ReadDecimal( string message )
        {
            Console.WriteLine(message);
            string value = Console.ReadLine();

            decimal result;
            if (Decimal.TryParse(value, out result)) //this will not use in this class again
                return result;

            return 0;
        }

        private static string name; //global variables
        private static string publisher;
        private static decimal price;
        private static bool owned;
        private static bool completed;

    }


}

//if you want to see the running solution you can add a breaker point(press F9 and you can cancel from same button)
//this will give you time to look at your solution in console

/*
 * developed by 2000
 * basic rules; case sensetive, white space no matter, 
 * C++ commenting; multi line comments and single line comment

    * cannot start identifier with a digit 
    * C# keywords are in blue
    * black are identifiers
    * comments are in green
    * strings are in red
    * if there is red underline that is a compiler error. you can mouse huver the error then it shows the details
    * error list is not quite good when showing error but output window is better than that. use it
    * green underlines are warnings. you can hurver it and they will tell you the details
    * if there is warnings you can loose points so, in assigmnets should not have warnings
    * block is paragraph of codes in the {}
    * if you wanna format click the format after you code. (ctrl+f) and if you wanna format whole document (ctrl+k)
    */

/*
 * function - use our big program to make smaller. function do not faster the program but they make it clean
 * static void Main( string[] args ) this is required in main function
 * int hours - variable declairation
 * when it functions you declair the function but you dont define it same time. but in variable you do define at the same time
 * function block shoud be like this; modifiers + type + function name + (parameters) + {} //without + mark
 * console class is a type in .NET
 * console in c# equals cout in c++ and printf in java
 * name of the function - WriteLine ; this is calling the function
 * for identifiers we do not use int a, b; of you do you will loose points
 */

/* integers;
 * sbyte 1 byte, 
 * short 2 ushort, 
 * int  4 uint,
 * long 8 ulong
 * 
 * floating points;
 * float 4 bytes
 * double 8 bytes
 * decimal 8 (only for currency)
 * 
 * char 2 bytes
 * bool 1 byte
 * 
 * string (unlimited)
 */

/*
 * January 23, 2019
 * Video game; we need 
 * name-string, publisher-string, completed-bool, price-decimal, owned-bool
 * 
 * parameters are variable you use the inside of the function body
 * arguments are the expression when you are calling the function
 * 
 * Decimal.Parse(String) converts to decimal
 * Decimal.tryparse(string,decimal) converts to bool
 * bool TryParse( string input, out decimal result ); // this result is output parameter 
 * 
 * strings are immutable means cannot be changed. cannot modify exsisting strings
 * 
 */
