// See https://aka.ms/new-console-template for more information

Console.OutputEncoding = System.Text.Encoding.UTF8; // Set the console output encoding to UTF-8
Console.InputEncoding = System.Text.Encoding.UTF8; // Set the console input encoding to UTF-8

Console.WriteLine("Hello, World!");  
Console.WriteLine("Input your name: ");  
var name = Console.ReadLine();

Console.WriteLine("Input your age: ");
var age = Console.ReadLine();

Console.WriteLine("Input your adress: ");
var adress = Console.ReadLine();

Console.WriteLine($"Hello, {name}!");
Console.WriteLine($"You are {age} years old.");
Console.WriteLine($"You live in {adress}.");

Console.ReadKey();