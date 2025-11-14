using System;

class Program
{
    static void Main(string[] args)
    {
        List<Reference> scriptureList = new List<Reference>()
        {
            new Reference("John", 3, 16),
            new Reference("Proverbs", 3, 5, 6)
        };
        List<string> scriptureTexts = new List<string>()
        {
            "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.",
            "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths."
        };
        Random randomGenerator = new Random();
        int randomIndex = randomGenerator.Next(0, scriptureList.Count);
        int randomReference = randomIndex;
        Reference _reference = scriptureList[randomIndex];
        String scriptureText = scriptureTexts[randomIndex];
        Scripture _scripture = new Scripture(_reference, scriptureText);
        bool isRunning = true;
        while (isRunning == true)
        {
            Console.Clear();
            Console.WriteLine(_scripture.GetDisplayText());
            Console.Write("Enter or Quit: ");
            string answer = Console.ReadLine();
            if (answer == "quit")
            {
                break;
            }
            else if (answer == "")
            {
                _scripture.HideRandomWords(3);
                if (_scripture.IsCompletelyHidden())
                {
                    break;
                }
            }
            else
            {
                return;
            }
        }
    }
}