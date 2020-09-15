using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic8BallProj
{
    class Program
    {

        static Random randomObject = new Random();
        static void Main(string[] args)
        {
            QuestionLoop();
        }
        static string GetQuestionFromUser()
        {
            Console.Write("What Question do you have? ");
            string questionString = Console.ReadLine();
            return questionString;


    }
        static void QuestionLoop()
        {
            string questionString = GetQuestionFromUser();
            int randomNumber = randomObject.Next(4);
            switch(randomNumber)
            {
                case 0:
                    {
                        Console.WriteLine("Yes!");
                        break;
                    }
                case 1:
                    {
                        Console.WriteLine("No!");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Bad Idea!");
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("That's a mystery for the ages!");
                        break;
                    }

            }
        }
    }
}
