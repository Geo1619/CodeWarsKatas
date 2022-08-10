
using System.Net;
Console.WriteLine(Kata.UInt32ToIP(4294967295));
public class Kata
{
    public static string UInt32ToIP(uint ip)
    {
        var bytes = BitConverter.GetBytes((uint)IPAddress.HostToNetworkOrder((int)ip));
        return String.Join('.', bytes);
    }
}