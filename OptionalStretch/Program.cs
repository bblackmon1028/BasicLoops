using System;

namespace OptionalStretch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lockCombo = 13579;
            bool accessGranted = AccessGranted();

            if (accessGranted)
            {
                Console.WriteLine("Welcome!");
            }
            else
            {
                Console.WriteLine("Too many attempts. Goodbye!");
            }

            bool AccessGranted()
            {
                int attempts = 1;
                bool locked = true;
                do
                {
                    Console.WriteLine("Please enter key code.");
                    int usersCode = Convert.ToInt32(Console.ReadLine());

                    if (usersCode == lockCombo)
                    {
                        locked = false;
                        return true;
                    }
                    else
                    {
                        locked = true;
                        Console.WriteLine("Not quite. Try again.");
                        attempts++;
                    }
                }
                while (locked && attempts <= 5);

                return false;
            }
        }
    }
}


