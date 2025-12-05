using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();
        Video video1 = new Video("Understanding Abstraction", "CodeMaster2024", 300);
        video1.AddComment(new Comment("Student1", "This makes so much sense now."));
        video1.AddComment(new Comment("DevGuru", "Great explanation of OOP concepts."));
        video1.AddComment(new Comment("NewbieCoder", "I was confused, but this helped."));
        videos.Add(video1);

        Video video2 = new Video("Top 10 C# Tips", "TechWithTim", 600);
        video2.AddComment(new Comment("ProGrammar", "Tip #3 changed my life!"));
        video2.AddComment(new Comment("CoffeeLover", "Too fast, I had to pause."));
        videos.Add(video2);

        Video video3 = new Video("My Cat Falls Asleep", "CutePetVids", 45);
        video3.AddComment(new Comment("CatLady", "Sooooo cute!!!"));
        video3.AddComment(new Comment("DogPerson", "Dogs are better."));
        video3.AddComment(new Comment("InternetTroll", "Why is this in my recommendations?"));
        video3.AddComment(new Comment("Fan1", "More cat videos please."));
        videos.Add(video3);

        foreach (Video video in videos)
        {
            video.DisplayInfo();
        }
    }
}