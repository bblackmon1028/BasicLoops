using System;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool playAgain;

            do
            {
                Console.WriteLine("Hello, World!");
                Console.WriteLine("Would you like to continue (y/n)?");
                string userAnswer = Console.ReadLine();

                if (userAnswer.ToLower() == "y")
                {
                    playAgain = true;
                }
                else
                {
                    playAgain = false;
                }

            }
            while (playAgain);

            Console.WriteLine("Goodbye!");
        }
    }
}
