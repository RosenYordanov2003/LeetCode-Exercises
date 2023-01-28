using System;
using System.Linq;

namespace Remove_Duplicates_from_Sorted_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int?[] array = new int?[10] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };

            for (int i = 0; i < array.Length; i++)
            {
                for (int z = i + 1; z < array.Length; z++)
                {
                    if (array[i] == array[z])
                    {
                        array[z] = null;
                    }
                }
            }
      
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == null && ThereIsMoreNumbers(i, array))
                {
                    int index = 0;
                    int? minNumber = FindMinNumber(i, array, ref index);
                    array[i] = minNumber;
                    SwapFunction(array, index);
                }
            }
            int k = array.Where(x => x != null).Count();

            Console.WriteLine(String.Join(", ", array));
            Console.WriteLine(k);
        }

        private static void SwapFunction(int?[] array, int index)
        {
            array[index] = null;
        }

        private static int? FindMinNumber(int index, int?[] array, ref int minNumberIndex)
        {
            int? min = int.MaxValue;
            for (int i = index; i < array.Length; i++)
            {
                if (array[i] < min && array[i] != null)
                {
                    min = array[i];
                    minNumberIndex = i;
                }
            }
            return min;
        }
        private static bool ThereIsMoreNumbers(int index, int?[] array)
        {
            for (int i = index; i < array.Length; i++)
            {
                if (array[i] != null)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
