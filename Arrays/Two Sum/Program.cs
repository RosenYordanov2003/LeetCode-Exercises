using System;

namespace leetCode_Array_problems
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] result = TwoSum(new int[] { 3,3},6);
            Console.WriteLine($"[{string.Join(",",result)}]");
        }
        public static int[] TwoSum(int[] nums, int target)
        {
            int[] output = new int[2];
            for (int i = 0; i < nums.Length; i++)
            {
                int firstNumber = nums[i];
                for (int z = i+1; z < nums.Length; z++)
                {
                    int secondNumber = nums[z];
                    if (firstNumber + secondNumber==target)
                    {
                        output[0] = i;
                        output[1] = z;
                        return output;
                    }
                }
            }
            return output;
        }
    }
}
