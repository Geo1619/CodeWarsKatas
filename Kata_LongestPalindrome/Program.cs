// See https://aka.ms/new-console-template for more information
Console.WriteLine(Kata.GetLongestPalindrome(""));
Console.WriteLine(Kata.GetLongestPalindrome(null));
Console.WriteLine(Kata.GetLongestPalindrome("a"));
Console.WriteLine(Kata.GetLongestPalindrome("aa"));
Console.WriteLine(Kata.GetLongestPalindrome("abc0cba1"));
Console.WriteLine(Kata.GetLongestPalindrome("12 21glg"));
Console.WriteLine(Kata.GetLongestPalindrome("   "));
public class Kata
{
    public static int GetLongestPalindrome(string? str)
    {
        var substrings = FindAllSubstrings(str ?? "");
        var reversedSubstrings = FindAllSubstrings(string.Concat(str?.Reverse() ?? "") );
        var commonSubstrings = substrings.Intersect(reversedSubstrings);
        string? longestSubstring = commonSubstrings.OrderByDescending(x => x.Length).FirstOrDefault();

        return longestSubstring?.Length ?? 0;

    }

    private static IEnumerable<string> FindAllSubstrings(string s)
    {
        List<string> list = new();
        for (int i = 0; i < s.Length; i++)
        {
            for (int j = i; j < s.Length; j++)
            {
                string ss = s.Substring(i, j - i + 1);
                list.Add(ss);
            }
        }
        return list;
    }
}