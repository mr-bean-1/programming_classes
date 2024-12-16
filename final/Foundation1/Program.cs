// to exceed requirements I added the views for videos and likes for the comments and the videos :)

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("\nWelcome to the Abstraction Youtube Program!");
        List<Video> videos = new List<Video>();

        // video 1
        Video video1 = new Video();
        video1.SetVideoMeta("Jimmy Converse", "How To Tie Your Shoes", 16);
        video1.SetVideoLikes(100);   
        video1.SetVideoDislikes(10);  
        video1.SetViews(2000);       
        
        // video 1 comments 
        Comment comment1 = new Comment("Maribel", "Nice one.", 10, 2); // 10 Likes, 2 Dislikes
        video1.SetComment(comment1);
        comment1 = new Comment("Hannah", "Very Enlightening!", 5, 1);  // 5 Likes, 1 Dislike
        video1.SetComment(comment1);
        comment1 = new Comment("Steve", "Now I won't trip!! Thanks bro!", 20, 0); // 20 Likes, 0 Dislikes
        video1.SetComment(comment1);
        videos.Add(video1);

        // video 2
        Video video2 = new Video();
        video2.SetVideoMeta("Carly Hansen", "Reasons Why Mr.Bean Was Voted Forbes Man of the Year", 45);
        video2.SetVideoLikes(200);    
        video2.SetVideoDislikes(5);   
        video2.SetViews(3500);       
        
        // video 2 comments
        comment1 = new Comment("James", "I love his comedy!", 15, 3); 
        video2.SetComment(comment1);
        comment1 = new Comment("Lily", "I have a teddy bear also called 'Teddy!'", 8, 2);
        video2.SetComment(comment1);
        comment1 = new Comment("Alistair", "Mr. Bean is the GOAT!", 25, 1); /
        video2.SetComment(comment1);
        videos.Add(video2);

        // video 3
        Video video3 = new Video();
        video3.SetVideoMeta("Tim Middleton", "Middle Child Syndrome", 13);
        video3.SetVideoLikes(150);    
        video3.SetVideoDislikes(8);   
        video3.SetViews(1200);        
        
        // video 3 comments
        comment1 = new Comment("Trent", "Is this an official diagnosis?", 12, 4); 
        video3.SetComment(comment1);
        comment1 = new Comment("Trina", "Hey, he remembered us!", 18, 2); 
        video3.SetComment(comment1);
        comment1 = new Comment("Jenny", "Haha!", 30, 0); 
        video3.SetComment(comment1);
        videos.Add(video3);

        DisplayVideoData(videos);
    }

    static void DisplayVideoData(List<Video> videos)
    {
        int count = 0;
        foreach (Video video in videos)
        {
            count++;
            Console.WriteLine($"Video {count}:");
            video.DisplayVideoData();  
        }
    }
}
