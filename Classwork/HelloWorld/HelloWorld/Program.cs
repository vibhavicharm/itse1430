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
            string name;
            int hours = 8; //8L for long
            double payRate = 8.25; //8.25 for Float


            Console.WriteLine(hours);

            Console.WriteLine("Enter your name: ");
            name = Console.ReadLine(); //assignning; variable = expression(they are must be same type)

            //string message = "Hello " + name; // this is working too in c#
            Console.Write("Hello ");
            Console.WriteLine(name);
                                        
        }
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
 * string 
 */

/*
 * 
 */