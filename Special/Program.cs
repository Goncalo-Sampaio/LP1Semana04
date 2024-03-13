using System;

namespace Special
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
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
