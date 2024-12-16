public class Video
{
    private string _author;
    private string _title;
    private int _length;
    private int _Likes;      
    private int _Dislikes;   
    private int _Views;       
    private List<Comment> _comments = new List<Comment>();

    public void SetVideoMeta(string author, string title, int length)
    {
        _author = author;
        _title = title;
        _length = length;
    }

    public void SetVideoLikes(int likes)
    {
        _Likes = likes;
    }

    public void SetVideoDislikes(int dislikes)
    {
        _Dislikes = dislikes;
    }

    public void SetViews(int views)
    {
        _Views = views;
    }

    public string GetAuthor() => _author;
    public string GetTitle() => _title;
    public int GetLength() => _length;
    public int GetLikes() => _Likes;
    public int GetDislikes() => _Dislikes;
    public int GetViews() => _Views;

    public void SetComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public void DisplayMetaData()
    {
        string meta = $"\nTitle: {GetTitle()}\nYoutuber: {GetAuthor()}\nVideo length: {GetLength()} minutes\nLikes: {GetLikes()} | Dislikes: {GetDislikes()}\nViews: {GetViews()}";
        Console.WriteLine(meta);
    }

    public void DisplayComments()
    {
        Console.WriteLine("\nComments:");
        foreach (var comment in _comments)
        {
            comment.DisplayComment();  
        }
    }

    public void DisplayVideoData()
    {
        DisplayMetaData();
        DisplayComments();  
    }
}
