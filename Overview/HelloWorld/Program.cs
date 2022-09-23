using System;

Console.WriteLine("Hello, World!");
Console.WriteLine("What is your name?");
string name = Console.ReadLine() ?? "nobody";
Console.WriteLine("Well, Hello there " + name);