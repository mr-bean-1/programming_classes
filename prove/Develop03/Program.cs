using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the scripture memorization program.");

        // create a list scripture for john 3:16
        Scripture scripture = new Scripture("John", 3, 16, "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life");

      List<Tuple<int, string>> articlesOfFaith = new List<Tuple<int, string>>
    //   create a tuple list so that we can have the number of the article printed for the user 
        {
            Tuple.Create(1, "We believe in God, the Eternal Father, and in His Son, Jesus Christ, and in the Holy Ghost."),
            Tuple.Create(2, "We believe that men will be punished for their own sins, and not for Adam’s transgression."),
            Tuple.Create(3, "We believe that through the Atonement of Christ, all mankind may be saved, by obedience to the laws and ordinances of the Gospel."),
            Tuple.Create(4, "We believe that the first principles and ordinances of the Gospel are: first, Faith in the Lord Jesus Christ; second, Repentance; third, baptism by immersion for the remission of sins; fourth, Laying on of hands for the gift of the Holy Ghost."),
            Tuple.Create(5, "We believe that a man must be called of God, by prophecy, and by the laying on of hands by those who are in authority, to preach the Gospel and administer in the ordinances thereof."),
            Tuple.Create(6, "We believe in the same organization that existed in the Primitive Church, namely, apostles, prophets, pastors, teachers, evangelists, and so forth."),
            Tuple.Create(7, "We believe in the gift of tongues, prophecy, revelation, visions, healing, interpretation of tongues, and so forth."),
            Tuple.Create(8, "We believe the Bible to be the word of God as far as it is translated correctly; we also believe the Book of Mormon to be the word of God."),
            Tuple.Create(9, "We believe all that God has revealed, all that He does now reveal, and we believe that He will yet reveal many great and important things pertaining to the Kingdom of God."),
            Tuple.Create(10, "We believe in the literal gathering of Israel and in the restoration of the Ten Tribes; that Zion (the New Jerusalem) will be built upon the American continent; that Christ will reign personally upon the earth; and, that the earth will be renewed and receive its paradisiacal glory."),
            Tuple.Create(11, "We claim the privilege of worshiping Almighty God according to the dictates of our own conscience, and allow all men the same privilege, let them worship how, where, or what they may."),
            Tuple.Create(12, "We believe in being subject to kings, presidents, rulers, and magistrates, in obeying, honoring, and sustaining the law."),
            Tuple.Create(13, "We believe in being honest, true, chaste, benevolent, virtuous, and in doing good to all men; indeed, we may say that we follow the admonition of Paul—We believe all things, we hope all things, we have endured many things, and hope to be able to endure all things. If there is anything virtuous, lovely, or of good report or praiseworthy, we seek after these things.")
        };

        Console.Clear();
        Console.WriteLine("Memorization Menu:");
        Console.WriteLine("1. Scripture (John 3:16)");
        Console.WriteLine("2. Random Article of Faith");
        Console.WriteLine("Enter your number:");

        string answer = Console.ReadLine();
        Console.WriteLine("\nPress Enter to continue or type quit to finish the program");

        Scripture currentScripture;

        if (answer == "1")
        {
            currentScripture = scripture;
        }
        else if (answer == "2")
        {
            // Randomly select an article of faith
            Random random = new Random();
            var randomArticle = articlesOfFaith[random.Next(articlesOfFaith.Count)];
            currentScripture = new Scripture($"Article of Faith {randomArticle.Item1}", 0, 0, randomArticle.Item2); 
        }
        else
        {
            Console.WriteLine("Wrong number. Try again. ");
            return; // Exit if the input is invalid
        }

        while (true)
        {
            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
                break;

            if (!currentScripture.HideRandomWord())
            {
                Console.WriteLine("You memorized the text!");
                break;
            }

            Console.Clear();
            currentScripture.Display();
            Console.WriteLine("\nPress Enter to continue or type 'quit' to exit");
        }
    }
}

