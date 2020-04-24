using System;
using System.Collections.Generic;
using System.Text;

/*  Problem: Write an algorithm to determine if a number n is "happy".
*  "What is Happy number": A happy number is a number defined by the following process: Starting with any positive integer, replace the number by the sum of                           the squares of its digits, and repeat the process until the number equals 1 (where it will stay), or it loops endlessly in a cycle                          which does not include 1. Those numbers for which this process ends in 1 are happy numbers.
*                          Return True if "N" is a happy number, and False if not.
*  Example:        Input: 19 | Output: true
*  Explanation:    Square(1) + Square(9) = 82
*                  Square(8) + Square(2) = 68
*                  Square(6) + Square(8) = 100
*                  Square(1) + Square(0) + Square(0) = 1
*                  (It means, input number 19 is a Happy number)
*/
namespace LeetCode.Problems
{    
    public class FindHappyNumber    //Problem 2
    {        
        public static bool CheckIfInputNumberIsHappy(int number)
        {
            int remainder; int addition; 
            bool output;
            List<int> storageList = new List<int>();    //List to store reduced values for comparison
            while (true)                                //For running loop endlessly
            {
                addition = 0;
                while (number != 0)                      
                {
                    remainder = number % 10;            
                    addition += remainder * remainder;
                    number = number / 10;
                }
                if (addition == 1)                      //If sum of the squares of its digits equals to 1, then its a Happy Number
                {
                    output = true; break;
                }
                else if (storageList.Contains(addition))    //Check if storage contains reduced sum value. 
                {                                           //If yes, loop is supposed to run endlessly and its not a Happy Number
                    output = false; break;
                }
                number = addition;
                storageList.Add(addition);
            }
            return output;
        }
    }
}
