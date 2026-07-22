using System;

class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comment;

    public Video()
    {
        _title = "";
        _author = "";
        _length = 0;
        _comment = new List<Comment>();
    }
    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        _comment = new List<Comment>();
    }
    public void AddComment(Comment comment)
    {
        _comment.Add(comment);
    }
    public void GetCommentCount()
    {
        Console.WriteLine($"Number of comments: {_comment.Count}");
    }
    public string DisplayInfo()
    {
        string info = $"Title: {_title}\nAuthor: {_author}\nLength: {_length} seconds\nComments:\n";
        foreach (Comment comment in _comment)
        {
            info += $"- {comment.GetText()} (by {comment.GetName()})\n";
        }
        return info;
    }
}