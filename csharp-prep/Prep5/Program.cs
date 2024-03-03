using System;

class Program
{
    static void Main(string[] args)
    {   
        DisplayWelcome();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();

        int squaredNumber = SquareNumber(userNumber);

        DisplayResult(userName, squaredNumber);

        // Console.WriteLine("Hello Prep5 World!");
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program");
        }
        static string PromptUserName()
        {
            Console.Write("Enter your user name: ");
            string user = Console.ReadLine();
            
            return user;

        }
        static int PromptUserNumber ()
        {
            Console.Write("Enter your favorite number: ");
            string userNum = Console.ReadLine();
            int userNumber = int.Parse(userNum);
            
            return userNumber;
        }
        static int SquareNumber (int squareNum)
        {
            int squar_ = squareNum * squareNum;
            return squar_;
        }
        static void DisplayResult(string userName , int square)
        {
            Console.WriteLine($"{userName}, the square of your number is {square}");
        }
    }
}