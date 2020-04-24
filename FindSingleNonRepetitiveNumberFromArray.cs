using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problems
{
    public class FindSingleNonRepetitiveNumberFromArray
    {
        /*  Problem 1 : Given a non-empty array of integers, every element appears twice except for one. Find that single one
         *  Condition : Your algorithm should a linear runtime complexity. Coul you implement it without using extra memory?
         *  Example Array - [4,1,2,1,2]
         *  Output : 4
         */
        public static int GetSingleNumber(int[] intergerArray)
        {
            //Let's solve this problem USING Bit Manipulation Approach
            int output = 0;
            for(int i = 0; i < intergerArray.Length; i++)
            {
                output = output ^ intergerArray[i];     // ^ [Bitwise operator]
            }
            return output;
        }
    }
}
