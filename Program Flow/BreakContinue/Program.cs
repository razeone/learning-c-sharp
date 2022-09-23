﻿using System;

namespace BreakContinue
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] values = {15, 7, 12, 23, 41, 28, 9, 17, 36, -1};

            Console.WriteLine("Using break and continue :");
            foreach (int val in values)
            {
                // TODO: The continue statement skips the rest of the loop entirely
                // and jumps to the next iteration (if there is one)
                Console.WriteLine("Val is currently {0}", val);

                if(val >= 20 && val <= 29){
                    Console.WriteLine("Twenties value found");
                    continue;
                }
                
                if(val >= 40){
                    break;
                }
                

            

                // print the value
                //Console.WriteLine($"val is currently {val}");

                // TODO: The break statement stops the loop and exits

            }
        }
    }
}
