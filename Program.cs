using System; // Подключаем библиотеку для работы с вводом-выводом

class Program
{
    static void Main()
    {
        // Запрашиваем имя пользователя
        Console.Write("Введите ваше имя: ");
        string name = Console.ReadLine(); // Считываем имя пользователя
        
        // Выводим приветственное сообщение
        Console.WriteLine($"Hello world from {name}!");
    }
}
