using System;

namespace Comments
{
    class Program
    {
        /// XML Comments are used to help provide documentation
        /// They start with triple-slashes and have a special syntax
        /// <summary>
        /// </summary>
        /// <param name="args">An array of elements</param>
        /// <return>
        /// 
        /// </return>
        static void Main(string[] args)
        {
            // This is a single line comment
            Console.WriteLine("Hello World!");
            /*
            This is 
            a 
            Multi-line
            comment
            */
        }
    }
}
