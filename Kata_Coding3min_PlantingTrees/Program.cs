using System;
using System.Linq;

namespace Kata_Coding3min_PlantingTrees
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("width:{0}, length:{1}, gaps:{2}", 3, 3, 1);
            Console.WriteLine("Trees to Plant: {0}", SC(3, 3, 1));

            
            Console.WriteLine("width:{0}, length:{1}, gaps:{2}", 3, 3, 3);
            Console.WriteLine("Trees to Plant: {0}", SC(3, 3, 3));

            
            Console.WriteLine("width:{0}, length:{1}, gaps:{2}", 3, 3, 2);
            Console.WriteLine("Trees to Plant: {0}", SC(3, 3, 2));

            
            Console.WriteLine("width:{0}, length:{1}, gaps:{2}", 7, 7, 3);
            Console.WriteLine("Trees to Plant: {0}", SC(7, 7, 3));

            
            Console.WriteLine("width:{0}, length:{1}, gaps:{2}", 3, 3, 0);
            Console.WriteLine("Trees to Plant: {0}", SC(3, 3, 0));






        }
        public static int SC(int width, int length, int gaps)
        {
            int trees = 0;
            int fieldLength = 2 * (width + length - 2);

            for (int i = 0; i < fieldLength; i+=gaps+1)
            {
                trees++;
            }

            return (fieldLength == (trees*gaps + trees) && trees%2==0) ? trees : 0;

        }
    }
}
