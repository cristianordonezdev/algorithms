using System;
using Algorithms;

class Program
{
    static void Main(string[] args)
    {
        //LongestSubstringWithoutRepeatingCharacters longest = new LongestSubstringWithoutRepeatingCharacters();
        //LongestPalindromicSubstring longest = new LongestPalindromicSubstring();
        ZigzagConversion solution = new ZigzagConversion();


        Console.WriteLine(solution.Convert("AB", 1));
    }
}