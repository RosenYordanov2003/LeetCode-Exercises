using System;
using System.Linq;

namespace Median_of_Two_Sorted_Arrays
{
    //When we find smaller element than the pivot, we increase the pivot index by 1
    //and swap the two elements on pivot index and other index.
    //In the end we put the pivot element on the current pivot index.
    //Divide the array on 
    public class Program
    {
        static void Main(string[] args)
        {
            double median = FindMedianSortedArrays(new int[2] { 1, 2 }, new int[2] {3,4});
            Console.WriteLine($"{median:F5}");
        }
        public static double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            double median = 0;
            int[] combinedArray = nums1.Concat(nums2).ToArray();
            QuickSort(combinedArray, 0, combinedArray.Length - 1);
            if (combinedArray.Length%2==0)
            {
                int firstElement = combinedArray[combinedArray.Length/2-1];
                int secondElement = combinedArray[combinedArray.Length/2];
                median = (firstElement + secondElement)/2.0;
            }
            else
            {
                median = combinedArray[combinedArray.Length/2];
            }
            return median;
        }
        public static void Swap(int[] array, int firstElementPosition, int secondElementPosition)
        {
            int temporaryFirstElement = array[firstElementPosition];
            array[firstElementPosition] = array[secondElementPosition];
            array[secondElementPosition] = temporaryFirstElement;
        }
        public static int PartitionFunctrion(int[] array, int leftSide, int rightSide)
        {
            int pivotPosition = leftSide;
            int pivotElement = array[leftSide];
            for (int i = leftSide + 1; i <= rightSide; i++)
            {
                if (array[i] < pivotElement)
                {
                    pivotPosition++;
                    Swap(array, pivotPosition, i);
                }
            }
            Swap(array, pivotPosition, leftSide);
            return pivotPosition;
        }
        public static void QuickSort(int[] array, int leftSide, int rightSide)
        {
            if (leftSide < rightSide)
            {
                int position = PartitionFunctrion(array, leftSide, rightSide);
                QuickSort(array, leftSide, position - 1);
                QuickSort(array, position + 1, rightSide);
            }
        }
    }
}
