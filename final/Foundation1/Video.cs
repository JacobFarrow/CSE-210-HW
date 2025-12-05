using System.ComponentModel.DataAnnotations;

class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments;
    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = new List<Comment>();
    }
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }
    public int GetCommentCount()
    {
        return _comments.Count();
    }
    public void DisplayInfo()
    {
        Console.WriteLine(@$"
-------------------------------------------
Title: {_title}
Author: {_author}
Length (seconds): {_length}
Comment count: {GetCommentCount()}");
        Console.WriteLine();
        foreach (Comment comment in _comments)
        {
            Console.WriteLine($"- {comment.GetDisplayText()}");
            Console.WriteLine();
        }
        Console.WriteLine(@$"-------------------------------------------");
    }
}