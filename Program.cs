using System;

namespace LeetCode.Problems
{
    class Program
    {
        static void Main(string[] args)
        {
            //Find single non-repetitive number from an array using Bit manipulation approach (XOR bitwise operator)
            //int[] intArray = { 4, 1, 2, 1, 2 };
            //Console.WriteLine($"Unique Number is {FindSingleNonRepetitiveNumberFromArray.GetSingleNumber(intArray)} from [4,1,2,1,2] array.");

            //int[] intArray1 = { 5, 4, 2, 4, 5, 6, 6, 2, 7 };
            //Console.WriteLine($"Unique Number is {FindSingleNonRepetitiveNumberFromArray.GetSingleNumber(intArray1)} from [5, 4, 2, 4, 5, 6, 6, 2, 7] array.");

            //Console.Write("Please enter a number : ");
            //int input1 = Convert.ToInt32(Console.ReadLine());
            //string result = FindHappyNumber.CheckIfInputNumberIsHappy(input1) ? "a Happy Number." : "not a Happy Number.";
            //Console.WriteLine($"Input number {input1} is {result}");
            //Console.Write("Please enter another number : ");
            //int input2 = Convert.ToInt32(Console.ReadLine());
            //string result2 = FindHappyNumber.CheckIfInputNumberIsHappy(input2) ? "a Happy Number." : "not a Happy Number.";
            //Console.WriteLine($"Input number {input2} is {result2}");

            //Problem 3
            int[] nums = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
            var result = FindMaximumSubarray.GetMaximumSubArray(nums);
            Console.WriteLine($"Maximun SubArray is [{string.Join(",", result.Item1.ToArray())}] from [{string.Join(",", nums)}] array.");
            Console.WriteLine($"Sum of Maximun SubArray is [{result.Item2}] from [{string.Join(",", nums)}] array.");
            //Console.WriteLine(string.Join(",", result.Item1.ToArray()));
            //Console.WriteLine(result.Item2);
            Console.ReadLine();
        }
    }
}
