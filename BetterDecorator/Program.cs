using System;

namespace BetterDecorator
{
    /// <summary>
    /// Class that will use the Main method to call Decor method using the
    /// arguments inserted by the user when running the program
    /// </summary>
    class Program
    {
        /// <summary>
        /// The Main method that will call the Decor method
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            if (args.Length == 3)
            {
                //parsing the arguments to use them in the Decor method
                char dec = char.Parse(args[1]);
                int n = int.Parse(args[2]);
                Console.WriteLine(Decor(args[0], dec, n));
            }
            else {
                Console.WriteLine(Decor());
            }

        }

        /// <summary>
        /// Method to add a char n number of times before and after a string
        /// </summary>
        /// <param name="s"></param>
        /// <param name="dec"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        private static string Decor(string s, char dec, int n)
        {
            string decor = "";

            //looping to create a string with the char n number of times
            for (int i = 0; i < n; i++)
            {
                decor += dec;
            }

            return $"{decor} {s} {decor}";
        }

        private static string Decor(){
            return Decor("User did not specify args!", '=', 3);
        }
    }
}
