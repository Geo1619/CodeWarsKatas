using System;


namespace Kata_SplitString
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Solution("asdfghhghh");
            Array.ForEach(arr, x => Console.WriteLine(x + " "));
        }
        public static string[] Solution(string str)
        {
            
            var even = str.Length % 2 == 0 ? (str).ToCharArray() : (str + "_").ToCharArray();
            string[] result = new string[even.Length/2];
            int j = 0;
            for (int i = 0; i < even.Length; i+=2)
            {
                result[j] = string.Concat(even[i],even[i + 1]);
                j++;
            }
            return result;
        }
    }

}
