using System;
using System.Linq;

namespace Kata_WhichAreIn
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = inArray(new[] { "arp","arp", "strong", "live" }, new[] { "lively", "alive", "harp", "sharp", "armstrong" });
            Array.ForEach(r, x => Console.WriteLine(x));
        }

        public static string[] inArray(string[] array1, string[] array2)
        {
            string[] r = Array.FindAll(array1, i => Array.Exists(array2, x => x.Contains(i))).Distinct().ToArray();
            Array.Sort(r);
            return r;
        }
    }
}
