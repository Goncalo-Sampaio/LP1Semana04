using System;

namespace BetterDecorator
{
    class Program
    {
        static void Main(string[] args)
        {
            //parsing the arguments to use them in the Decor method
            char dec = char.Parse(args[1]);
            int n = int.Parse(args[2]);
            Console.WriteLine(Decor(args[0], dec, n));
        }

        private static string Decor(string s, char dec, int n){
            string decor = "";

            //looping to create a string with the char n number of times
            for (int i = 0; i < n; i++) {
                decor += dec;
            }

            return $"{decor} {s} {decor}"; 
        }
    }
}
