class ReflectionActivity : Activity
{
    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();

    public ReflectionActivity() : base("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
        _prompts.Add("Think of a time when you stood up for someone else.");
        _prompts.Add("Think of a time when you did something really difficult.");
        _prompts.Add("Think of a time when you helped someone in need.");
        _prompts.Add("Think of a time when you did something truly selfless.");

        _questions.Add("Why was this experience meaningful to you?");
        _questions.Add("Have you ever done anything like this before?");
        _questions.Add("How did you get started?");
        _questions.Add("How did you feel when it was complete?");
        _questions.Add("What made this time different than other times when you were not as successful?");
        _questions.Add("What is your favorite thing about this experience?");
        _questions.Add("What could you learn from this experience that applies to other situations?");
        _questions.Add("What did you learn about yourself through this experience?");
        _questions.Add("How can you keep this experience in mind in the future?");
    }
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int randomInt = random.Next(_prompts.Count);
        return _prompts[randomInt];
    }
    public string GetRandomQuestion()
    {
        Random random = new Random();
        int randomInt = random.Next(_questions.Count);
        return _questions[randomInt];
    }
    public void Run()
    {
        DisplayStartingMessage();
        string randomPrompt = GetRandomPrompt();
        Console.WriteLine($"Consider the following prompt: {randomPrompt}");
        Console.WriteLine("Press enter when you are ready.");
        Console.ReadLine();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        while(DateTime.Now < endTime)
        {
            string randomQuestion = GetRandomQuestion();
            Console.WriteLine($"Please answer the following: {randomQuestion}");
            ShowSpinner(10);
        }
        DisplayEndingMessage();
    }
}