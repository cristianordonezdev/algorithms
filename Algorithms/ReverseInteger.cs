using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{

    //Given a signed 32-bit integer x, return x with its digits reversed.If reversing x causes the value to go outside the signed 32-bit integer range[-231, 231 - 1], then return 0.
    //Assume the environment does not allow you to store 64-bit integers(signed or unsigned

    //Example 1:

    //Input: x = 123
    //Output: 321
    internal class ReverseInteger
    {

        // Runtime 24 ms
        public int Reverse(int x)
        {
            bool isNegative = x < 0;
            char[] chars = x.ToString().Substring(isNegative ? 1 : 0).ToCharArray();

            Array.Reverse(chars);

            string xString = isNegative ? "-" : "";
            xString += new String(chars);
            try
            {
                return int.Parse(xString);

            } catch (Exception e)
            {
                return 0;
            }
        }
    }
}
