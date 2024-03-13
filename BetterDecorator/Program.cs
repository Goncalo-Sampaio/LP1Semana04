using System;

namespace BetterDecorator
{
    class Program
    {
        static void Main(string[] args)
        {
            //parsing the arguments to use them in the Decor method
            char dec = Char.Parse(args[1]);
            int n = Char.Parse(args[2]);
            Console.WriteLine(Decor(args[0], dec, n));
        }

        private static string Decor(string s, char dec, int n){
               return $"{dec}{dec}{dec}{s}{dec}{dec}{dec}"; 
        }
    }
}
