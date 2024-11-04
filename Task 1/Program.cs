using System;


class Program
{
    static void Main()
    {
        int currentNumber = 1;

        int limit = 20;
        while (currentNumber <= limit)
        {
            if (currentNumber % 2 == 0)
            {
                Console.WriteLine(currentNumber);
            }
            currentNumber++;
        }
        Console.ReadLine();
    }
}

