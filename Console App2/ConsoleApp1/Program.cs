using System;
class Program
{
    static void Main()
    {
        string? input;
        Console.WriteLine("Программа запущена. Введите текст (для выхода введите 'выход'):");

        while (true)
        {
            Console.Write("> ");
            input = Console.ReadLine();
            if (input == null)
            {
                continue;
            }
            if (input.ToLower() == "выход")
            {
                Console.WriteLine("До встречи!");
                break;
            }
            Console.WriteLine($"Вы сказали: {input}");
        }
    }
}
 
