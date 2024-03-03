using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Prep3 World!");
        Console.Write("Enter the magic number: ");
        string magicNumber = Console.ReadLine();
        int  magicNumberInt = int.Parse(magicNumber);

        Console.Write("Enter your number: ");
        string yourNumber = Console.ReadLine();
        int yourNumberInt = int.Parse(yourNumber);

        while (yourNumberInt != magicNumberInt)
        {
            
            if (yourNumberInt > magicNumberInt)
            {
                Console.WriteLine("Higher");
            }
            else if (yourNumberInt < magicNumberInt){
                Console.WriteLine("Lower");
            }
            else{
                Console.WriteLine("You got it !");
            }
           
            Console.Write("Enter your guess: ");
            yourNumber = Console.ReadLine();
            yourNumberInt = int.Parse(yourNumber);
            
        }
        
        Console.WriteLine("Good that is the magic number!!!");

        
        


    }
}