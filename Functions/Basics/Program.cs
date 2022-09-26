using System;

// Functions are used to group re-usable code together in a single
// unit that can be customized with parameters.

// TODO: Functions have a return type, name, and optional parameters
float MilesToKm(float miles) {
    return miles * 1.60934f;
}


// TODO: A function with no return value has a 'void' type
void PrintWithPrefix(string theStr, string prefix = "") {
    Console.WriteLine($"{prefix} {theStr}");
}

// TODO: Call first function
Console.WriteLine($"The result is {MilesToKm(8.0f):F2} km");
Console.WriteLine($"The result is {MilesToKm(52.0f)}");

// TODO: Call second function
PrintWithPrefix("Hello World");
PrintWithPrefix("Hello Again", "==>");


PrintWithPrefix(prefix: ">>>",
                theStr: "Hello Again");

