public class Video
{
    private string _title;
    private string _author;
    private string _length;
    private List<Comment> _comments;

    public Video(string title, string author, string length){
        _title = title;
        _author = author;
        _length = length;
        _comments = new List<Comment>();
    }

    private int GetCommentCount()
    {
        return _comments.Count;
    }

    public void Display()
    {
        Console.WriteLine($"\n\nTitle: {_title}\nAuthor: {_author}\nLength: {_length}\nNumber of Comments: {GetCommentCount()}");
        foreach(Comment i in _comments)
        {
            i.Display();
        }
    }

    public void AddComment(string name, string comment)
    {
        Comment newComment = new Comment(name, comment);
        _comments.Add(newComment);
    }
}