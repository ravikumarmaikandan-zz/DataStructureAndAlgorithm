using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public static class Numbers
    {
        public static void DoFindIndexsBasedOnTargetSum(this int[] nums, int targetSum)
        {
            Console.WriteLine("Input Array: " + string.Join(",", nums));
            var result = FindIndexsBasedOnTargetSum(nums, targetSum);
            if(result!= nums)
            {
                Console.WriteLine("Indexs are :" + string.Join(",", result));
            }
        }
        public static void DoFindTwoNumbersBasedOnTargetSum(this int[] nums, int targetSum)
        {
            Console.WriteLine("Input Array: " + string.Join(",", nums));
            var result = FindTwoNumbersBasedOnTargetSum(nums, targetSum);
            if (result != nums)
            {
                Console.WriteLine("Numbes are :" + string.Join(",", result) + "For TargeSum:" + targetSum.ToString());
            }
        }

        public static int[] FindIndexsBasedOnTargetSum(int[] nums, int targetSum)
        {
            var hash = new Hashtable();
            int[] result = null;
            for (int i = 0; i < nums.Length; i++)
            {
                var diff = targetSum - nums[i];

                if(hash.ContainsKey(diff))
                {
                    result = new int[] { (int)hash[diff], i };
                    return result;
                }
                else
                {
                    hash.Add(nums[i], i);
                }
            }

            return result;
        }

        public static int[] FindTwoNumbersBasedOnTargetSum(int[] nums, int targetSum)
        {
            var hash = new Hashtable();
            int[] result = null;
            for (int i = 0; i < nums.Length; i++)
            {
                var diff = targetSum - nums[i];

                if (hash.ContainsKey(diff))
                {
                    result = new int[] { (int)nums[i], diff };
                    return result;
                }
                else
                {
                    hash.Add(nums[i], 1);
                }
            }

            return result;
        }
    }
}
