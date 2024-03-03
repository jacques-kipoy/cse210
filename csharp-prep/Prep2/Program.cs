using System;
using System.Xml.XPath;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Prep2 World!");
        Console.Write("Please enter your grade? ");
        string grade = Console.ReadLine();
        int numGrade = int.Parse(grade);
        string theResult ="";
        

        if (numGrade >= 90)
        {
            theResult = "You got an A, congratulations !";
        }
        else if (numGrade >= 80)
        {
            theResult = "You got a B, congratulations, do your best to get an A next time!";
        }
        else if (numGrade >= 70)
        {
            theResult = "You got a C, congratulations, do your best to get an A next time!";
           
        }
        else if (numGrade >= 60)
        {
            theResult = "You got a D, Please do your best next time to get an A";
        }
        else if (numGrade < 60)
        {
            theResult = "You got an F, Please do your best next time, and try to ask for help!";
        }
        Console.WriteLine($"{theResult}");
        if (numGrade >= 70){
            Console.WriteLine("You Passed!");
        }
        else{
            Console.WriteLine("Goodluck, you can try again, you can do it !");
        }
        
    }   
}