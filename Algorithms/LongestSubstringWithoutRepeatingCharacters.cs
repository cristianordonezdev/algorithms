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
            // FIRST SOLUTION
            // public int LengthOfLongestSubstring(string s) {


            //     List<int> ListLength = new List<int> { 0 };

            //     string substring = "";
            //     if (s.Count() == 1)
            //     {
            //         ListLength[0] = 1;
            //     } else
            //     {

            //         for (int i = 0; i < s.Count(); i++ )
            //         {    
            //             for (int k = i; k < s.Count(); k++ )
            //             {
            //                 if (!substring.Contains(s[k]))
            //                 {
            //                     substring += s[k];
            //                 } else {

            //                     ListLength.Add(substring.Count());
            //                     substring = "";
            //                     break;
            //                 }

            //             }

            //         }

            //         ListLength.Sort();
            //     }

            //     return ListLength[ListLength.Count() - 1];
            // }

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
