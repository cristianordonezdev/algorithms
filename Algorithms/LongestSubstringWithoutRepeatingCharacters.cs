using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    internal class LongestSubstringWithoutRepeatingCharacters
    {
        public int LengthOfLongestSubstring(string s)
        {

            //HashSet<char> substrings = new HashSet<char>();
            //HashSet<int> ListLength = new HashSet<int> { 0 };

            //if (s.Count() == 1)
            //{
            //    ListLength.Add(1);
            //} else
            //{

            //    for (int i = 0; i < s.Count(); i++ )
            //    {    
            //       if (!substrings.Contains(s[i]))
            //        {
            //                substrings.Add(s[i]);
            //        }
            //       else

            //        {

            //                for (int j = i; j != 0; j= j -2)
            //                {
            //                    Console.WriteLine("Elimino " + s[j]);
            //                    substrings.Remove(s[j]);
            //                    foreach (char a in substrings)
            //                    {

            //                        Console.Write("--" + a + ".");
            //                    }

            //                }
            //            }

            //    }

            //    //ListLength.Sort();
            //}

            //foreach(char a in substrings)
            //    {

            //        Console.WriteLine(a);
            //    }

            //    return substrings.Count();
            //}

            // s = pwwkew

            HashSet<char> set = new HashSet<char>();
            int left = 0;
            int maxLength = 0;

            for (int right = 0; right < s.Length; right++)
            {
                while (set.Contains(s[right]))
                {
                    set.Remove(s[left]);
                    left++;
                }

                set.Add(s[right]);
                maxLength = Math.Max(maxLength, right - left + 1);
            }

            return maxLength;
        }
    }
}
