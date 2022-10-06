using System;

namespace KeypadEntry
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool locked = true;
            int lockCombo = 13579;

            while (locked)
            {
                Console.WriteLine("Please enter a key code.");
                int usersCode = Convert.ToInt32(Console.ReadLine());
                if (usersCode == lockCombo)
                {
                    locked = false;
                    Console.WriteLine("Welcome!");
                }
                else
                {
                    locked = true;
                    Console.WriteLine("Not quite. Please try again.");
                }
            }
        }
    }
}


