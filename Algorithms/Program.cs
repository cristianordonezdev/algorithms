using System;
using Algorithms;

class Program
{
    static void Main(string[] args)
    {
        LongestSubstringWithoutRepeatingCharacters longest = new LongestSubstringWithoutRepeatingCharacters();
        Console.WriteLine(longest.LengthOfLongestSubstring("pwwkew"));
    }
}