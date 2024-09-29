using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int square = SquareNumber();
        DisplayResult(square, name);
    }
    static void DisplayWelcome(){
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName(){
        Console.WriteLine("What is your name? ");
        string name = Console.ReadLine();
        Console.WriteLine($"Your name is {name}");
        return name; 

    }

     static int SquareNumber(){
        Console.WriteLine("Enter a number: ");
        string number = Console.ReadLine();
        int value = int.Parse(number);
        int square = value * value;  
        Console.WriteLine($"The squared number is {square}");
        return square; 



    }

     static void DisplayResult(int square, string name){
        Console.WriteLine($"Your name is {name} and the squared num is {square}");

    }



}
