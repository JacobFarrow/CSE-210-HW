using System;

class Program
{
    static void Main(string[] args)
    {
        string input = "0";
        int totalCount = 0;
        while(input != "4")
        {
            Console.WriteLine(@"
1. Start breathing activity

2. Start reflection activity

3. Start listing activity

4. Quit");
        input = Console.ReadLine();
        if (input == "1")
        {
            BreathingActivity breathing = new BreathingActivity();
            breathing.Run();
            totalCount++;
        }
        else if (input == "2")
        {
            ReflectionActivity reflection = new ReflectionActivity();
            reflection.Run();
            totalCount++;
        }
        else if (input == "3")
        {
            ListingActivity listing = new ListingActivity();
            listing.Run();
            totalCount++;
        }
        }
    Console.WriteLine($"You have completed {totalCount} activities today!");
    }
}