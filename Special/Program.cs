using System;

namespace Special
{
    /// <summary>
    /// This program uses user input and a recursive method to return a value
    /// </summary>
    class Program
    {
        /// <summary>
        /// Main method that will call the GetSpecial method using user input
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //Asks the user for an input and parses it to an int to use it as
            //argument in the GetSpecial method
            Console.Write("Insert n-th number of the special sequence: ");
            string input = Console.ReadLine();
            int i = int.Parse(input);
            Console.WriteLine(GetSpecial(i));
        }

        /// <summary>
        /// Recursive method that will return the value of the previous number
        /// + twice the value of the number-2
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        private static int GetSpecial(int i)
        {
            //base case
            int special;
            if (i == 0)
            {
                special = 0;
            }
            //second base case
            else if (i == 1)
            {
                special = 1;
            }
            //recursive part of the method
            else
            {
                special = GetSpecial(i - 1) + 2 * GetSpecial(i - 2);
            }

            return special;
        }
    }
}
