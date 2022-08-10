using System;
using System.Text.RegularExpressions;

namespace Kata_ValidatePin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ValidatePin("1234").ToString());
            Console.WriteLine(ValidatePin("0000").ToString());
            Console.WriteLine(ValidatePin("1111").ToString());
            Console.WriteLine(ValidatePin("123456").ToString());
            Console.WriteLine(ValidatePin("098765").ToString());
            Console.WriteLine(ValidatePin("000000").ToString());
            Console.WriteLine(ValidatePin("090909").ToString());
        }
        public static bool ValidatePin(string pin)
        {
            Regex regex = new Regex(@"\d{4}\b");
            return regex.Match(pin).Success;
             
        }
    }
}
