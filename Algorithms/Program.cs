using System;
using Algorithms;

class Program
{
    static void Main(string[] args)
    {
        //LongestSubstringWithoutRepeatingCharacters longest = new LongestSubstringWithoutRepeatingCharacters();
        //LongestPalindromicSubstring longest = new LongestPalindromicSubstring();
        //ZigzagConversion solution = new ZigzagConversion();
        //ReverseInteger reverseInteger = new ReverseInteger();
        StringToInteger stringToInteger = new StringToInteger();
        //PalindromeNumber palindromeNumber = new PalindromeNumber();
        ContainerWithMostWater containerWithMostWater = new ContainerWithMostWater();

        Console.WriteLine(containerWithMostWater.MaxArea([1, 8, 6, 2, 5, 4, 8, 3, 7]));
    }
}