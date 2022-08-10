// See https://aka.ms/new-console-template for more information
using System.Text.RegularExpressions;
using System.Linq;

Console.WriteLine("Hello, World!");


Console.WriteLine(Kata.Alphanumeric("Mazinkaiser") + " must be TRUE");
Console.WriteLine(Kata.Alphanumeric("Mazin.kai_ser") + " must be FALSE");
Console.WriteLine(Kata.Alphanumeric("hello world_") + " must be FALSE");
Console.WriteLine(Kata.Alphanumeric("PassW0rd") + " must be TRUE");
Console.WriteLine(Kata.Alphanumeric("     ") + " must be FALSE");
Console.WriteLine(Kata.Alphanumeric("") + " must be FALSE");
Console.WriteLine(Kata.Alphanumeric(" ") + " must be FALSE");

public class Kata
{
    public static bool Alphanumeric(string str)
    {
        var regex = new Regex(@"[_\W]+");
        return str != string.Empty && !regex.IsMatch(str);
    }
}