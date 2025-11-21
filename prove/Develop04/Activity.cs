class Activity
{
    private string _name;
    private string _description;
    protected int _duration;
    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }
    public void DisplayStartingMessage()
    {
        Console.WriteLine(@$"Welcome to your activity!
Today you will be doing a {_name}.
{_description}");
        Console.WriteLine("How long (in seconds) would you like to do this for? ");
        _duration = int.Parse(Console.ReadLine());
    }
    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
    public void ShowSpinner(int seconds)
    {
        List<string> loading = new List<string>() {"|", "/", "-", "|", "\\"};
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);
        int i = 0;
        while (DateTime.Now < endTime)
        {
            Console.Write(loading[i]);
            Thread.Sleep(250);
            Console.Write("\b \b");
            i++;
            if(i > loading.Count - 1)
            {
              i = 0;  
            }
        }
    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine("Good Job!");
        ShowSpinner(5);
        Console.WriteLine($"You have completed {_name} for {_duration} seconds.");
        ShowSpinner(5);
    }
}