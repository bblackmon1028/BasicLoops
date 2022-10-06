using System;

namespace DoWhileKeypadEntry
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool locked = true;
            int lockCombo = 13579;
            int attempts = 1;

            do
            {
                Console.WriteLine("Please enter key code.");
                int usersCode = Convert.ToInt32(Console.ReadLine());
                if (usersCode == lockCombo)
                {
                    locked = false;
                    Console.WriteLine("Welcome!");
                }
                else if(attempts < 5)
                {
                    locked = true;
                    Console.WriteLine("Not quite. Please try again");
                    attempts++;
                }
                else
                {
                    Console.WriteLine("Too many attempts. Goodbye");
                    break;
                }
            }
            while (locked);
        }
    }
}



