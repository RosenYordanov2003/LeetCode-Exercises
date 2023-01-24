using System;
using System.Linq;

namespace Container_With_Most_Water
{
    //area min(element1,element2)*posDiff
    //55 tests from 61 test were passed
    public class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[9] { 1, 8, 6, 2, 5, 4, 8, 3, 7 };
            int result = MaxArea(array);
            Console.WriteLine(result);
        }
        public static int MaxArea(int[] height)
        {
            int leftSide = 0,
            rightSide = height.Length - 1,
            currentArea = 0,
            max = int.MinValue;
            while (leftSide < rightSide)
            {
                currentArea = (rightSide - leftSide) * Math.Min(height[leftSide], height[rightSide]);
                if (currentArea > max)
                {
                    max = currentArea;
                }

                if (height[leftSide] <= height[rightSide])
                {
                    leftSide++;
                }
                else
                {
                    rightSide--;
                }
            }
            return max;

        }
    }
}
