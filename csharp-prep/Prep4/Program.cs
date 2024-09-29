using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {

      List<int> numbers = new List<int> ();

      int num = -1;  
      while (num != 0){
            
            Console.WriteLine("Enter a list of numbers, type 0 when finished.");
            string number = Console.ReadLine();
            num = int.Parse(number);

            if (num != 0){
                numbers.Add(num);
            }
            
        }

        int sum = 0;
        foreach (int number in numbers){
            sum += number;
        
    }
    Console.WriteLine($"The ume is: {sum}");
    float average = ((float)sum) / numbers.Count;
    Console.WriteLine($"The average is: {average}");

    int max = numbers[0];
    foreach (int number in numbers){
        if (number > max){
            max = number;
        }
    }
    Console.WriteLine($"The max is: {max}");
    }


  
}
