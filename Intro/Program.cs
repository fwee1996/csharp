//Given in program:
// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");



// In module:
// Initially:

// using System;

// namespace Intro
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Console.WriteLine("Hello World!");
//         }
//     }
// }
// ``  `

//Delete all above and just:
// System.Console.WriteLine("Hello World!");

//Terminal: dotnet run


//Type a name and it'll say Hello (Name)! Otherwise terminal will say Fine, don't say 'hello'!
// System.Console.Write("Who would you like to say hello to? ");

// string name = System.Console.ReadLine();

// if (string.IsNullOrWhiteSpace(name))
// {
//     System.Console.WriteLine("Fine, don't say 'hello'!");
// }
// else
// {
//     System.Console.WriteLine($"Hello, {name}!");
// }


//Final:
using System;

Console.Write("Who would you like to say hello to? ");

string name = Console.ReadLine();

if (string.IsNullOrWhiteSpace(name))
{
    Console.WriteLine("Fine, don't say 'hello'!");
}
else
{
    Console.WriteLine($"Hello, {name}!");
}