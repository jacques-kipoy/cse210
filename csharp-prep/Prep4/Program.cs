using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep4 World!");
        // using System.Collections.Generic;
        List <int> ListNumbers =  new List<int>();
        
        Console.WriteLine("Enter a list of numbers, type 0 when finished");

        Console.Write("Enter the number: ");
        string num = Console.ReadLine();
        int numInt = int.Parse(num);

        // int num1 = -1;


        while (numInt != 0) {
            
            Console.WriteLine("Enter the number: ");
            num = Console.ReadLine();
            numInt = int.Parse(num);

            if (numInt != 0){
                ListNumbers.Add(numInt);
            }

        }
        // The sum 
        int sum = 0;
        foreach (int number in ListNumbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is {sum}");

        // The average 
        float average = sum / ListNumbers.Count;
        Console.WriteLine($"the average is {average}");


        int maxNum = ListNumbers[0];

        foreach (int number in ListNumbers)
        {
            if (number > maxNum)
            {
                // find the max number 
                maxNum = number;
            }
        }

        Console.WriteLine($"The max is: {maxNum}");
    }
}