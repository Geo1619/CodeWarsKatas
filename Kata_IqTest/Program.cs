using System;
using System.Linq;

namespace Kata_IqTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Test("2 4 7 8 10"));
        }
        public static int Test(string numbers)
        {
            var list = numbers.Split(" ").ToList();

            var index = list.Where(x => int.Parse(x) % 2 != 0).Count() > 1 ? list.FindIndex(x => int.Parse(x) % 2 == 0) : list.FindIndex(x => int.Parse(x) % 2 != 0);
            return ++index;
        }
    }
}
