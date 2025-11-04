using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        Console.WriteLine("I have a number between 1 and 100, can you work it out?");
        int Number;

        do
        {
            Console.Write("What is your guess? ");
            Number = int.Parse(Console.ReadLine());

            if (magicNumber > Number)
            {
                Console.WriteLine("Too low");
            }
            else if (Number > magicNumber)
            {
                Console.WriteLine("Too high");
            }
            else
            {
                Console.WriteLine("That is correct.");
            }
        } while (Number != magicNumber);
    }
}