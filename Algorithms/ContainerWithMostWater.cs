using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    internal class ContainerWithMostWater
    {
        //public int MaxArea(int[] height)
        //{

        //    int maxArea = 0;

        //    for (int i = 0; i < height.Count(); i++)
        //    {
        //        for(int j = i + 1; j < height.Count(); j++)
        //        {

        //            int op = height[height[i] >= height[j] ? j : i] * (Math.Abs(i - j));
        //            //Console.WriteLine(height[j] + " x " + Math.Abs(i - j) + " = " + height[j] * (Math.Abs(i - j)));
        //            //areas.Add();
        //            if (op > maxArea) maxArea = op;

        //            //Console.WriteLine(height[i] + " -- " + height[j]);

        //        }
        //    }

        //    return maxArea;
        //}

        public int MaxArea(int[] height)
        {

            int maxArea = 0;
            HashSet<string> set = new HashSet<string>();
            for (int i = 0; i < height.Count(); i++)
            {
                for (int j = i + 1; j < height.Count(); j++)
                {

                    if (set.Contains(height[height[i] >= height[j] ? j : i] + "" + Math.Abs(i - j))) continue;
                    else
                    {
                        set.Add(height[height[i] >= height[j] ? j : i] + "" + Math.Abs(i - j));
                        int op = height[height[i] >= height[j] ? j : i] * (Math.Abs(i - j));
                        //Console.WriteLine(height[j] + " x " + Math.Abs(i - j) + " = " + height[j] * (Math.Abs(i - j)));
                        //areas.Add();
                        if (op > maxArea) maxArea = op;

                        //Console.WriteLine(height[i] + " -- " + height[j]);

                    }

                }
            }

            return maxArea;
        }
    }
}
