using System;

class Program
{
    static void Main()
    {
        // Ask for user's name
        Console.Write("Введите ваше имя: ");
        string name = Console.ReadLine(); // Reading user's name
        
        // Print welcome message
        Console.WriteLine($"Hello world from {name}!");
    }
}
