// optional feature I am working on: making a random list of scripture for user to choose from. 

// using System;
// class Scripture{
//     public class ScriptureRandom{
//         List<string> prompts = new List<string>{
//             // john 3:16
//             "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life", 
//             // james 1:5
//             "If any of you lack wisdom, let him ask of God, that giveth to all men liberally, and upbraideth not; and it shall be given him.",
//             // proverbs 3:5 
//             "Trust in the Lord with all your heart and lean not on your own understanding.", 
//             // mosiah 4:9
//             "Believe in God; believe that he is, and that he created all things, both in heaven and in earth; believe that he has all wisdom, and all power, both in heaven and in earth; believe that man doth not comprehend all the things which the Lord can comprehend.", 
//             // 2 nephi 2:25
//             "Adam fell that men might be; and men are, that they might have joy",
//             // alma 32:21
//             "And now as I said concerning faith—faith is not to have a perfect knowledge of things; therefore if ye have faith ye hope for things which are not seen, which are true.", 
//             // luke 1:37
//             "For with God nothing shall be impossible."
        
//         };
//     }
    
// } 


using System;
using System.Collections.Generic; 
class Scripture{
    private Reference _reference; 
    private List<Word> _words; 

    public Scripture(string book, int chapter, int verse, string text ){
        _reference = new Reference(book, chapter, verse);
        _words = new List<Word> (); 

        string[] splitText = text.Split(' ');
        foreach (string word in splitText){
            _words.Add(new Word(word));
        }
    }



    public void Display(){

        Console.WriteLine($"{_reference}:");
        foreach (Word word in _words){
            if (word.IsHide()){
                Console.Write(new string('_', word.GetText().Length) + "");
            }
            else{
                Console.Write(word.GetText() + " ");
            }
        }
        Console.WriteLine();

    }

    public bool HideRandomWord(){
        List<Word> visibleWords = GetVisibleWords();
        if (visibleWords.Count < 2)
            return false; 

        Random random = new Random();
        int randomIndex1 = random.Next(visibleWords.Count);
        int randomIndex2; 

        do{
            randomIndex2 = random.Next(visibleWords.Count);

        }

        while (randomIndex1 == randomIndex2);

        visibleWords[randomIndex1].Hide();
        visibleWords[randomIndex2].Hide();
        return true; 

    }

    private List<Word> GetVisibleWords(){

        List<Word> visibleWords = new List<Word>();
        foreach (Word word in _words){
            if (!word.IsHide())
                visibleWords.Add(word);
        }

        return visibleWords; 

    }



}




