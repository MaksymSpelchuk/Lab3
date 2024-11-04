using System;


class Program
{
    static void Main()
    {
        Console.WriteLine("Введіть число:");
        int number = int.Parse(Console.ReadLine());


        string binary = Convert.ToString(number,2);

        Console.WriteLine("Двійкове представлення: " + binary);
    }
}
