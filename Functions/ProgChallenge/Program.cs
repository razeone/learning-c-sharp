using System;
using System.Text;
// See https://aka.ms/new-console-template for more information

namespace Palindromes
{
    class Program
    {

        static (bool, int) IsPalindrome(string str)
        {
            string teststr;
            teststr = str.ToUpper();
            var sb = new StringBuilder();
            foreach (char c in teststr)
            {
                if (!char.IsPunctuation(c) && !char.IsWhiteSpace(c))
                {
                    sb.Append(c);
                }                
            }
            teststr = sb.ToString();

            int i=0, j = teststr.Length - 1;
            while (i <= j)
            {
                if (teststr[i] != teststr[j])
                {
                    return (false, teststr.Length);
                }
                i++;
                j--;
            }
            return (true, teststr.Length);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Let's begin:");
            string CONTROL_VAR = "exit";
            string inputstr = "";
            (bool a, int b) result;
            while(inputstr != CONTROL_VAR) {
                inputstr = Console.ReadLine();
                if(inputstr != CONTROL_VAR) {
                    result = IsPalindrome(inputstr);
                    Console.WriteLine($"Palindrome: {result.a} Length: {result.b}");
                }
            }
        }
    }
}