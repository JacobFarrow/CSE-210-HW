class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>();
    public ListingActivity() : base("Listing Activity","This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
    }
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int randomInt = random.Next(_prompts.Count);
        return _prompts[randomInt];
    }
    public void Run()
    {
        DisplayStartingMessage();
        string randomPrompt = GetRandomPrompt();
        Console.WriteLine(randomPrompt);
        Console.WriteLine("Have a short think.");
        ShowCountDown(10);
        _count = 0;
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        while(DateTime.Now < endTime)
        {
            Console.WriteLine($"Please write:");
            Console.ReadLine();
            _count++;
        }
        Console.WriteLine($"You have listed: {_count} items.");
        DisplayEndingMessage();
    }
}