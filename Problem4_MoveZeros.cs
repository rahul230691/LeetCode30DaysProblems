using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problems
{
    /* Problem 4 : Given an array nums, write a function to move all 0's to the end of it while maintaining the relative order of the non-zero elements. 
    *  Example - Input: [0,1,0,3,12] || Output: [1,3,12,0,0]
    *  Conditions: 1. You must do this in-place without making a copy of the array.
                   2. Minimize the total number of operations.
    */
    public class Problem4_MoveZeros
    {
        public static int[] GetMovedZerosArray(int[] nums)
        {
            //Since we can not use extra array as per condition 1, so let's solve it using 2-Pointers technique.
            int left_pointer = 0;                           //"right_pointer" variable will move to right side of array.
            int right_pointer = 0;                          //"left_pointer" variable will follow right_pointer only
            int temp = 0;                                   //"temp" will be used for swapping purpose only
            if (nums.Length == 0 || nums.Length == 1)       //if provided array is empty or have one element only, then just return same array.
                return nums;
            for(int i = 0; i < nums.Length; i++)
            {
                if(nums[right_pointer] == 0)                //if nums[right_pointer] is equals to Zero, just increment right_pointer by 1.                        
                    right_pointer++;
                else                                        //else increase both pointers by 1 after swapping values.
                {
                    temp = nums[left_pointer];                  //Swapping logic 
                    nums[left_pointer] = nums[right_pointer];
                    nums[right_pointer] = temp;
                    left_pointer++; right_pointer++;            //increment both pointers by 1
                }
            }
            return nums;
        }
    }
}
