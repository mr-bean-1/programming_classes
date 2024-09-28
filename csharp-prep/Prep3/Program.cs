using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        //  guess my number

        Random randomGenerator = new Random();
        int random_num = randomGenerator.Next(1, 101);

        int guess = 0;

        while (guess != random_num){
            Console.Write("Choose a random number from 1-100: ");

            guess = int.Parse(Console.ReadLine());

            if (guess > random_num) {
            Console.WriteLine("Guess higher: ");
            }

            if (guess < random_num) {
            Console.WriteLine("Guess lower: ");
            }
            else {
                Console.WriteLine("You guessed the right number.");
            }

            }

        }

    }



