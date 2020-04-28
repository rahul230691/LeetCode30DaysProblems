using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problems
{
    /*  Problem 3 : Given an integer array nums, find the contiguous subarray (containing at least one number) which has the largest sum and return its sum. 
    *  Example Array - Input: [-2,1,-3,4,-1,2,1,-5,4] 
    *  Output : 6
    *  Explanation: [4,-1,2,1] has the largest sum = 6.
    */
    public class FindMaximumSubarray
    {
        public static Tuple<List<int>, int> GetMaximumSubArray(int[] nums)
        {
            int maximum_end_here = 0; int maximum_so_far = 0; int start = 0; int end = 0; int temp = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                maximum_end_here = maximum_end_here + nums[i];
                if (maximum_end_here < 0)
                {
                    maximum_end_here = 0;
                    temp = i + 1;
                }
                if(maximum_so_far < maximum_end_here)
                {
                    maximum_so_far = maximum_end_here;
                    start = temp;
                    end = i;
                }                    
            }
            List<int> resultArray= new List<int>();
            for (int j = start; j <= end; j++)
                resultArray.Add(nums[j]);
            return Tuple.Create(resultArray, maximum_so_far);
        }
    }
}
