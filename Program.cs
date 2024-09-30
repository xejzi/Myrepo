using System; //улучшенный код.

class Program
{
    static void Main()
    {
        Console.Write("Введите ваше имя: ");
        string name = Console.ReadLine(); 
        Console.WriteLine($"Hello world from {name}!");
    }
}
