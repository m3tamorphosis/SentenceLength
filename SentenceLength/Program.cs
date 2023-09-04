using System.Text.RegularExpressions;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Input Sentence");
        string? sen = Console.ReadLine();
        Console.WriteLine(LongestWord(sen));
        Console.ReadLine();
    }

    static string LongestWord(string? sen)
    {
        if (string.IsNullOrEmpty(sen))
        {
            return "sen is null";
        }
        sen = Regex.Replace(sen, @"[^\w\d\s]", "");
        int senLength = 0;
        string longest = "";
        String[] arr = sen.Split(' ');
        foreach (String s in arr)
        {
            if(s.Length > senLength)
            {
                senLength = s.Length;
                longest = s;
            }
        }
        return longest;
    }
}