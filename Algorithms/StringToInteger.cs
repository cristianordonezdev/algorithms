using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Reflection.PortableExecutable;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Algorithms
{
    internal class StringToInteger
    {

        //Implement the myAtoi(string s) function, which converts a string to a 32-bit signed integer.

        //The algorithm for myAtoi(string s) is as follows:

        //Whitespace: Ignore any leading whitespace(" ").
        //Signedness: Determine the sign by checking if the next character is '-' or '+', assuming positivity if neither present.
        //Conversion: Read the integer by skipping leading zeros until a non-digit character is encountered or the end of the string is reached.If no digits were read, then the result is 0.
        //Rounding: If the integer is out of the 32-bit signed integer range [-231, 231 - 1], then round the integer to remain in the range. Specifically, integers less than -231 should be rounded to -231, and integers greater than 231 - 1 should be rounded to 231 - 1.
        //Return the integer as the final result.



        //Example 1:

        //Input: s = "42"

        //Output: 42

        //Explanation:

        //The underlined characters are what is read in and the caret is the current reader position.
        //Step 1: "42" (no characters read because there is no leading whitespace)
        //         ^
        //Step 2: "42" (no characters read because there is neither a '-' nor '+')
        //         ^
        //Step 3: "42" ("42" is read in)
        public int MyAtoi(string s)
        {
            s = s.Trim();
            
            bool isCharacterInBeginnig = false;
            bool isNegative = false;
            string digit = "";

            if (s.Count() > 1)
            {
                
                if (s[0].ToString().Equals("+") || s[0].ToString().Equals("-"))
                {
                    isNegative = s[0].ToString().Equals("-");
                    s = s.Substring(1);
                }

                for (int i = 0; i < s.Count(); i++)
                {
                    if (!char.IsDigit(s[0]) && i == 0)
                    {
                        isCharacterInBeginnig = true;
                        break;
                    }

                    if (char.IsDigit(s[i])) digit += s[i];
                    else break;
                }
                if (isNegative) digit = "-" + digit;

                try
                {
                    return isCharacterInBeginnig ? 0 : int.Parse(digit);

                }
                catch (Exception e)
                {
                    List<int> limits = new List<int> { (int)Math.Pow(2, 31) + 1, (int)Math.Abs(Math.Pow(2, 31)) };
                    return isNegative ? limits[0] : limits[1];
                }
            }
            else if (s.Count() == 1)
            {
                if (char.IsDigit(s[0])) return int.Parse(s[0] + "");
                else return 0;

            }
            else return 0;
        }
    }
}
