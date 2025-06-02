using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{

    //Given an integer x, return true if x is a palindrome, and false otherwise.

    //Example 1:

    //Input: x = 121
    //Output: true
    //Explanation: 121 reads as 121 from left to right and from right to left.
    internal class PalindromeNumber
    {
        public bool IsPalindrome(int x)
        {
            char [] numbers = x.ToString().ToCharArray();
            Array.Reverse(numbers);

            return new String(numbers).Equals(x.ToString());
        }
    }
}
