using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Algorithms
{

    //Given a string s, return the longest palindromic substring in s.

    //Example 1:

    //Input: s = "babad"
    //Output: "bab"
    //Explanation: "aba" is also a valid answer.


    //Example 2:

    //Input: s = "cbbd"
    //Output: "bb"
    internal class LongestPalindromicSubstring
    {
        //public string LongestPalindrome(string s)
        //{
        //    // Passing 52 from 142 cases
        //    string longest_palindroms = "";

        //    for (int i = 0; i <= s.Length; i++)
        //    {

        //        for (int j = 0; j < s.Length - (i - 1); j++)
        //        {

        //            string sub = s[j..(j + i)];
        //            Console.WriteLine(sub + " <-- ");
        //            bool isPalindrom = IsPalindromic(sub);
        //            if (isPalindrom && sub.Count() > longest_palindroms.Count()) longest_palindroms = sub;
        //        }
        //    }



        //    Console.WriteLine("Palindromo -> " + longest_palindroms);

        //    return longest_palindroms;
        //}

        //public bool IsPalindrom(string s)
        //{
        //    char[] reverseString = s.ToCharArray();
        //    Array.Reverse(reverseString);
        //    //Console.WriteLine("original --> " + s + " reversed --> " + new string(reverseString));
        //    return (s.Equals(new string(reverseString)));
        //}


        // Better way to do it
        //public bool IsPalindrom(string s)
        //{
        //    int left = 0;
        //    int right = s.Length - 1;

        //    while (left < right)
        //    {
        //        if (s[left] != s[right])
        //        {
        //            return false;
        //        }

        //        left++;
        //        right--;
        //    }

        //    return true;
        //}

        //public void FirstFunction(string s)
        //{
        //    List<string> palindroms = new List<string>();

        //    int j = 1;
        //    for (int i = 0; i < s.Length; i++)
        //    {
        //        if (s[i] == s[j] && i == 0)
        //        {

        //        }
        //        else if (s[i] == s[j] && i != 0)
        //        {
        //            palindroms.Add(s[i] + "" + s[j]);

        //            bool isPalindrom = true;
        //            int TemporalI = i;
        //            int TemporalJ = j;
        //            while (isPalindrom)
        //            {
        //                TemporalI = TemporalI != 0 ? TemporalI - 1 : 0;
        //                TemporalJ = TemporalJ != (s.Count() - 1) ? TemporalJ + 1 : s.Count() - 1;

        //                string sub = s.Substring(TemporalI, TemporalJ + 1);
        //                Console.WriteLine(sub + " -- " + IsPalindrom(sub));

        //                isPalindrom = IsPalindrom(sub);
        //                if (isPalindrom)
        //                {
        //                    palindroms.Add(sub);
        //                }
        //            }
        //        }

        //        j++;
        //    }
        //}


        // Bettew way to do it
        public string LongestPalindrome(string s)
        {
            if (string.IsNullOrEmpty(s) || s.Length < 1)
                return "";

            int start = 0, end = 0;

            for (int i = 0; i < s.Length; i++)
            {
                int len1 = ExpandFromCenter(s, i, i);       // Centro impar
                int len2 = ExpandFromCenter(s, i, i + 1);   // Centro par
                int len = Math.Max(len1, len2);

                if (len > end - start)
                {
                    start = i - (len - 1) / 2;
                    end = i + len / 2;
                }
            }

            return s.Substring(start, end - start + 1);
        }

        private int ExpandFromCenter(string s, int left, int right)
        {
            while (left >= 0 && right < s.Length && s[left] == s[right])
            {
                left--;
                right++;
            }

            return right - left - 1; // Longitud del palíndromo
        }


    }
}
