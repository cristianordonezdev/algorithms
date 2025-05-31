using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace Algorithms
{
//    The string "PAYPALISHIRING" is written in a zigzag pattern on a given number of rows like this: (you may want to display this pattern in a fixed font for better legibility)

//    P A H N
//    A P L S I I G
//    Y I R
//And then read line by line: "PAHNAPLSIIGYIR"

//Write the code that will take a string and make this conversion given a number of rows:

//string convert(string s, int numRows);


//    Example 1:

//Input: s = "PAYPALISHIRING", numRows = 3
//Output: "PAHNAPLSIIGYIR"


    internal class ZigzagConversion
    {
        // this option resolves 1157 of 1157 testcases with 1367 ms 
        public string Convert(string s, int numRows)
        {

            if (numRows > 1)
            {

                int numSpaces = numRows - 2;


                List<List<char>> matrix = new List<List<char>>();
                List<char> row = new List<char>();

                int rowZeros = 0;
                int columnZero = 0;

                for (int i = 0; i < s.Count(); i++)
                {
                    if (rowZeros == (numSpaces + 1))
                    {
                        rowZeros = 0;
                        columnZero = 0;
                    }
                    if (rowZeros == 0)
                    {
                        row.Add(s[i]);
                       
                    } else
                    {
                        int internalWhile = 0;
                        while (internalWhile < numRows)
                        {
                            if (columnZero < numSpaces)
                            {
                                row.Add('-');
                               
                                columnZero++;
                            } else if(columnZero == numSpaces)
                            {
                                row.Add(s[i]);
                                
                                columnZero = 0;
                            }

                            internalWhile++;

                        }

                        matrix.Add(row);
                      
                        row = new List<char>();
                        rowZeros++;
                    }

                    if (row.Count() == numRows || i == s.Count() - 1)
                    {
                        int rowCount = row.Count();
                        for (int j = 0; j < numRows - rowCount; j++)
                        {
                            row.Add('-');
                        }
                        matrix.Add(row);
                        row = new List<char>();
                        rowZeros++;
                    }

                }

            
                return Matrix(matrix, numRows);
            } else
            {
                return s;
            }
        }
        public string Matrix(List<List<char>> matrix, int numRows)
        {
            string str = "";
            for (int column = 0; column < numRows; column++)
            {
                for (int j = 0; j < matrix.Count(); j++)
                {
                  
                    if (!matrix[j][column].Equals('-')) str += matrix[j][column];

                }
            }

            return str;
        }
    }

}
