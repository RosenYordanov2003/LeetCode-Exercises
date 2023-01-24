using System;
using System.Collections.Generic;
using System.Linq;

namespace Three_Sum
{
    public class Program
    {
        static void Main(string[] args)
        {

        }
        private static IList<IList<int>> ThreeSum(int[] nums)
        {
            IList<IList<int>> result = new List<IList<int>>();
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    for (int k = i + 2; k < nums.Length; k++)
                    {
                        if (nums[i] + nums[j] == 0 && nums[k]>0)
                        {
                            continue;
                        }
                        if (i != j && i != k && j != k)
                        {
                            if (nums[i] + nums[j] + nums[k] == 0)
                            {
                                List<int> currentCollection = new List<int>() { nums[i], nums[j], nums[k] };
                                if (!CheckForDuplicate(result, currentCollection))
                                {
                                    result.Add(new List<int> { nums[i], nums[j], nums[k] });
                                }
                            }
                        }
                    }
                }
            }
            return result;
        }

        private static bool CheckForDuplicate(IList<IList<int>> result, List<int> currentCollection) =>
             result.Any(x => x.All(currentCollection.Contains) && currentCollection.All(x.Contains));
    }
}



