using System;

Console.WriteLine("Who would you like to say hello to?");

string name = Console.ReadLine();

if (string.IsNullOrWhiteSpace(name))
{
    Console.WriteLine("No Hello?");
}
else
{
    Console.WriteLine($"Hello, {name}!");
}
