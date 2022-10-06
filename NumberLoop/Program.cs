using System;

namespace NumberLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool repeat;

            do
            {
                Console.WriteLine("Enter a number");
                int userNumber = Convert.ToInt32(Console.ReadLine());

                for (int i = userNumber; i >= 0; i--)
                {
                    Console.WriteLine(i);

                }

                for (int i = 0; i <= userNumber; i++)
                {
                    Console.WriteLine(i);
                }

                Console.WriteLine("Would you like to continue? (y/n)");
                string userContinue = Console.ReadLine();

                if (userContinue.ToLower() == "y")
                {
                    repeat = true;
                }
                else
                {
                    Console.WriteLine("Goodbye!");
                    repeat = false;
                }
            }
            while (repeat);
        }
    }
}