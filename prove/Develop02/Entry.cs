using System;

public class Entry
{
    string _date;
    string _prompt;
    string _userResponse;

    public Entry(string date, string prompt, string userResponse)
    {
        _date = date;
        _prompt = prompt;
        _userResponse = userResponse;
    }
    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_prompt}");
        Console.WriteLine($"Response: {_userResponse}");
        Console.WriteLine();
    }

    public string GetAsFileString()
    {
        
        return $"{_date}|{_prompt}|{_userResponse}";
    }
}