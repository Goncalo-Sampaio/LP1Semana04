using System;

namespace Special
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insert n-th number of the special sequence: ");
            string input = Console.ReadLine();
            int i = int.Parse(input);
            Console.WriteLine(GetSpecial(i));
        }

        private static int GetSpecial(int i)
        {
            int special;
            if (i == 0)
            {
                special = 0;
            }
            else if (i == 1)
            {
                special = 1;
            }
            else
            {
                special = GetSpecial(i - 1) + 2 * GetSpecial(i - 2);
            }

            return special;
        }
    }
}
