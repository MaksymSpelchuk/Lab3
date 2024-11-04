using System;


class Program
{
    static void Main()
    {
        Console.WriteLine("Введіть число:");
        int number = int.Parse(Console.ReadLine());

        int factorial = 1; 

        for (int i = 1; i <= number; i++)
        {
            factorial *= i;
        }
        Console.WriteLine("Факторіал числа " + number + " дорівнює " + factorial);

    }
}