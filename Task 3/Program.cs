using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введіть число:");
        int number = int.Parse(Console.ReadLine());

        int multiplication = 0;

        for (int i = 1; i < 10; i++)
        {
            multiplication = number * i;
            Console.WriteLine(multiplication);
        }
    }
}
