using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare some variables to excercise the operators
            int x=10, y=5;
            string a="abcd", b="efgh";

            // TODO: Basic math operators are +, -, /, *
            // Console.WriteLine("----- Basic Math -----");
            // Console.WriteLine("X plus Y equals to {0}", x + y);
            // Console.WriteLine("X minus Y equals to {0}", x - y);
            // Console.WriteLine("X times Y equals to {0}", x * y);
            // Console.WriteLine("X divided Y equals to {0}", x / y);

            // Console.WriteLine("A plus B equals to {0}", a + b);


            // TODO: Increment / decrement operators
            Console.WriteLine("----- Shorthand -----");
            x++;
            y++;
            // Console.WriteLine(x);
            // Console.WriteLine(y);

            


            // TODO: Operators can be shorthand: a = a + b
            a += b;
            //Console.WriteLine(a);


            // TODO: Logical operators &&, ||
            Console.WriteLine(x > y);
            Console.WriteLine(x < y || false);
            
            // Console.WriteLine("----- Logic Operators -----");


            // null-coalescing operators
            string str = null;
            Console.WriteLine(str ?? "Unknown string");
            // string str = null;
            // TODO: the ?? operator uses left operand if not null, or right one if it is
            str ??= "New String";
            Console.WriteLine(str);
            
            // TODO: the ??= operator assigns the right operand if the left one is null
            // it replaces the code:
            // if (variable is null) {
            //    variable = somevalue;
            // }

        }
    }
}
