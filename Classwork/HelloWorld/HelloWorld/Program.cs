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
            path += "\\Temp";
            string path2 = @"C:\Windows\System32"; //verbatim string is an escape sequence

            // 1.String concat
            Console.WriteLine("Name: " + name);

            // 2. String Format
            String str = String.Format("Price: {0:C}", price); //this is the long way. there are two ways. this :C format the string to currency. means format the two digits automatically
            Console.WriteLine(str);

            //Console.WriteLine("Price: " + price); this line and "String str = String.Format("Price: {0}", price);" are same

            // 3. Function overload - just calls String.Format
            Console.WriteLine("Publisher: " + publisher);

            // 4. Concatenation
            str = String.Concat("Owned? ", " ", owned);
            Console.WriteLine(str);
            //Console.WriteLine("Owned? " + owned);

            // 5. Interpolation - (this adds two formulas together)
            //Console.WriteLine("Completed? " + completed);   - step 1         
            //Console.WriteLine("Completed? {0}", completed); - step 2
            Console.WriteLine($"Completed? {completed}"); // - step 3 - any expression can go here within limits

            // Convert to a string
            string strPrice = price.ToString("C"); // any expression can convert to string like this ".ToString()"
                                                   //string strLiteral = "Hello".ToString(); - you can do this too, but it doest need. LOL
                                                   //ReadBoolean("Hello").ToString - anything can be converted to strings
                                                   //10.ToString(); - "10"

            //Is string empty
            string input = ""; // initialize to an emoty string
            string input2 = null; // null is not an empty string. means there are no value
            // if your function assigns to null your program will crash. .length, .ToString like functions cannot be null
            int length = input.Length; // length is int. this is funtion but no
            bool isEmpty;

            // 1.
            //if (input != null)
            //    isEmpty = input.Length == 0;
            //else
            //    isEmpty = true;

            // 2.
            isEmpty = (input != null) ? input.Length == 0 : true; //? asks if the boolean is true or not - conditional operator

            isEmpty = input.Length == 0;

            // 3.
            isEmpty = input == "";

            // 4.
            isEmpty = input == String.Empty; // is an example of a constant
            //these 3 do the same thing

            // 5.
            isEmpty = String.IsNullOrEmpty(input); //same thing but easier because computer do it for you

            //Comparison
            bool areEqual = "Hello" == "hello"; // this is false because it is case sensitive
            areEqual = String.Compare("Hello", "hello", true) == 0;

            //Conversion
            input = input.ToLower();
            input2 = input2.ToUpper();

            //Manipulation function
            bool startsWith = input.StartsWith("http:");
            bool endsWith = input.EndsWith("/");
            //these are important at parsing

            input = input.TrimStart();
            input = input.TrimEnd(); 
            input = input.Trim();

            // good for buiding out tables 
            input = input.PadLeft(10);
            input = input.PadRight(10, '-'); //- you can use for devide title and values in a table. this draw a dash line between them 
        }

        private static bool ReadBoolean(string message)
        {
            do
            {
                Console.WriteLine(message);
                string result = Console.ReadLine().ToUpper(); //convert to upper.

                //Validate it is a boolean
                //HACK: Fix this expression
                if (result == "Y")
                    return true;
                if (result == "N")
                    return false;

                //switch (result) - this is same as if statement
                //{
                //    case "Y":  
                //    case "y": return true; 

                //    case "N": 
                //    case "n": return false; 

                //    default: Console.WriteLine("Enter Y or N"); break; //this is not special. so, it must have break;
                //};

                //if (result == "Y" || result == "y") - you can write thses to lines together like in this line
                //if (result == "y")
                //    return true;
                //if (result == "n")
                //    return false;


                Console.WriteLine("Enter Y or N");
            } while (true);

            //TODO: Add validation 
            //return false; 
        }

        private static decimal ReadDecimal( string message )
        {
            while (true)
            {
                Console.WriteLine(message);
                string value = Console.ReadLine();

                //decimal result;
                ///if (Decimal.TryParse(value, out result))            
                if (Decimal.TryParse(value, out decimal result))
                    return result;

                Console.WriteLine("Enter a valid decimal value: ");
            }; //c# does not care. but sometimes may or may not work while loop if you don't add ;
            
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

/* January 23, 2019
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

/* January 28, 2019
 * once a string value is determined you cannot change it. 
 * String concatination
 * {0:C} format specifier; this one formats as currency. C is currency
 * All functions are camel case
 * length - int
 * IsNullOrEmpty - bool
 * Compare(strr,str,bool) - int
 * ToUpper/ToLower
 * StratsWith/EndWith
 * Trim
 * PadLeft/PadRight
 * While, do-while and switch
 * Type inference - var means compiler you go and figure out that(line 76) - var path2 = @"C:\Windows\System32"; - string was there instead of var.
 * compiler will figure out that was a string automatically. so, we can add var instead of string. this does not change the type
 * var i = 10; - since 10 is an int i is an int. var help you LOL.because it lets compiler to figure out what is the type. you can use var 
 * anywhere. you cannot declare var without initializing. 
 */
