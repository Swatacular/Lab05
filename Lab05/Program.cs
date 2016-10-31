using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05
{
    class Program
    {
        static void Main(string[] args)
        {
            bool trueEqualsYes;
            Random randyRandom = new Random();
            int outputDie1;
            int outputDie2;
            GreetAndWantToPlay(out trueEqualsYes);
            while (true)
            {
                outputDie1 = GetRandomNumber(randyRandom);
                outputDie2 = GetRandomNumber(randyRandom);
                Console.WriteLine("Die 1: " + outputDie1);
                Console.WriteLine("Die 2: " + outputDie2);

                GreetAndWantToPlay(out trueEqualsYes);
                if (trueEqualsYes == false) break;
            }
        }

        static void GreetAndWantToPlay(out bool trueEqualsYes)
        {
            do
            {
                Console.Write("Welcome to the Grand Circus Casino! Roll the dice? (y/n): ");
            } while (!(AskBoolInput(out trueEqualsYes)));
            //continues to greet and ask if they want to play as long as there is invalid input.
        }
        static bool AskBoolInput(out bool trueEqualsYes)
        {
            string input = Console.ReadLine();
            //Checks for multiple ways to reply with yes or no.
            if (input.ToLower() == "y" || input.ToLower() == "yes")
            {
                trueEqualsYes = true; //"out" the answer
                return true; //returning that it is a valid input
            } else if (input.ToLower() == "n" || input.ToLower() == "no")
            {
                trueEqualsYes = false;
                return true;
            }
            Console.Clear();
            Console.WriteLine("Invalid answer, please try again. . .");
            trueEqualsYes = false;
            return false;
        }

        static int GetRandomNumber(Random randy)
        {
            return randy.Next(1, 6);
        }


    }
}
