using System;

class Program
{
    static void Main(string[] args)
    {
        /* Console.WriteLine("Hello World!");
        Console.Write("Woah.");
        Console.WriteLine("Hi."); */

        Console.Write("What is your favouite number? ");
        int Number = int.Parse(Console.ReadLine());

        if (Number > 5 || Number < 15)
        {
            Console.WriteLine($"Your answer was {Number}, which is not in the range I expected.");
        }

        else
        {
            Console.WriteLine($"Ah, {Number}. Just as I thought. It is usually between 5-14");
        }
    }
}