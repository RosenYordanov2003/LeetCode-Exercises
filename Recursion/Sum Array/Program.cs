using System;

namespace Sum_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[5] { 10, 9, 8, 7, 6 };
            int startIndex = 0;
            int result = SumArray(array, startIndex);
            Console.WriteLine(result);
        }

        static int SumArray(int[] array, int startIndex)
        {
            if (startIndex==array.Length)
            {
                return 0;
            }
            return array[startIndex]+SumArray(array,startIndex+1);
        }
    }
}
