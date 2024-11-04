using System;

class Program
{
    static void Main()
    {
        Console.Write("Введіть число: ");
        int limit = int.Parse(Console.ReadLine());

        int a = 0;
        int b = 1;
        int sum = 0;
        int count = 0;

        while (a < limit)
        {
            sum += a;
            count++;

            int temp = a;
            a = b;
            b = temp + b;
        }

        Console.WriteLine("Сума чисел Фібоначчі: " + sum);
        Console.WriteLine("Кількість елементів: " + count);
    }
}

