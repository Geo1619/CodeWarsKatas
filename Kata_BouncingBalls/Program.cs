using System;

namespace Kata_BouncingBalls
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(BouncingBall(30.0, 0.66, 1.5));
        }
        public static int BouncingBall(double h, double bounce, double window)
        {
            int result = -1;
            if (h > 0 && window < h && (bounce > 0 && bounce < 1))
            {
                result = 1;
                h *= bounce;
                while (h > window)
                {
                    result+=2;
                    h *= bounce;
                }
            }
            return result;

            //if (h <= 0 || bounce <= 0 || bounce >= 1 || window >= h || window <= 0) return -1;
            //var result = 2 + BouncingBall(h * bounce, bounce, window);
            //return result;
        }
    }
}
