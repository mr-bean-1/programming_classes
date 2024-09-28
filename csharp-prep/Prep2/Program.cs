using System;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade? ");
        string value = Console.ReadLine();
        int  grade = int.Parse(value);

         // a 90
         // b 80
         //c 70 
         // d 60
         // f 60 

         if (grade >= 90){

            Console.WriteLine("Your grade is an a. ");
         }
         else if (grade >= 80){
            Console.WriteLine("Your grade is an b. ");
         }

        else if (grade >= 70){
            Console.WriteLine("Your grade is an c. ");
         }

         else if (grade >= 60){
            Console.WriteLine("Your grade is an d. ");
         }

         else {
            Console.WriteLine("Your grade is an f. ");
         }

    }
}
