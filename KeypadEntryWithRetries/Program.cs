using System;

namespace KeypadEntryWithRetries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool locked = true;
            int lockCombo = 13579;
            int attempts = 5;

            while (locked)
            {
                for (int i = 1; i <= attempts; i++)
                {
                    Console.WriteLine("Enter a key code.");
                    int usersCode = Convert.ToInt32(Console.ReadLine());
                    if (usersCode == lockCombo)
                    {
                        locked = false;
                        Console.WriteLine("Welcome!");
                        break;
                    }
                    else
                    {
                        locked = true;
                        if (i == attempts)
                        {
                            Console.WriteLine("Too many incorrect attempts. Goodbye");
                        }
                        else
                        {
                            Console.WriteLine("Not quite. Please try again.");
                        }
                    }
                }
                break;
            }
        }
    }
}


