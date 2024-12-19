public class Comment
{
    private string _Name;
    private string _Comment;
    private int _Likes;       
    private int _Dislikes;    

    public Comment(string name, string comment, int likes, int dislikes)
    {
        _Name = name;
        _Comment = comment;
        _Likes = likes;            
        _Dislikes = dislikes;      
    }

    public void DisplayComment()
    {
        Console.WriteLine($"{_Name}: {_Comment} | Likes: {_Likes} | Dislikes: {_Dislikes}");
    }

    public string GetName() => _Name;
    public string GetComment() => _Comment;
}
