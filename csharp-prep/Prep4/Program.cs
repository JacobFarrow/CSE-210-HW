using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int number;
        List<int> numbers = new List<int>();

        do
        {
            Console.Write("Enter a number: ");
            number = int.Parse(Console.ReadLine());
            if (number > 0)
            {
                numbers.Add(number);
            }
        } while (number != 0);

        int sum = 0;

        foreach (int num in numbers)
        {
            sum += num;
        }

        if (numbers.Count > 0)
        {
            float average = sum / numbers.Count;
            int largest = numbers.Max();
            int smallest = numbers.Min();

            Console.WriteLine($"The sum of the list is: {sum}");
            Console.WriteLine($"The average of the list is: {average}");
            Console.WriteLine($"The largest number of the list is: {largest}");
            Console.WriteLine($"The smallest positive number of the list is: {smallest}");
        }
        else
        {
            Console.WriteLine("There is no list.");
        }
    }
}