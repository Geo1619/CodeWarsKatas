using System;

namespace Kata_Dubstep
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SongDecoder("RWUBWUBWUBLWUB")); 
        }
        public static string SongDecoder(string input)
        {
            return string.Join(" ", input.Split("WUB", StringSplitOptions.RemoveEmptyEntries));
        }
    }
}
