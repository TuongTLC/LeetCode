using System.Numerics;

namespace LeetCode;

public class EasyProblems
{
    //TwoSum
    //Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to
    //target.
    public int[] TwoSum(int[] nums, int target)
    {
        for(int i = 0; i < nums.Length-1; i++){
            for(int j = i+1; j < nums.Length; j++){
                if( nums[i]+nums[j] == target){
                    return new[]{i,j};
                }
            }
        }
        throw new Exception("Not found!!!");
    }
    
    
    //Length of Last Word
    //Given a string s consisting of words and spaces, return the length of the last word in the string.
    public int LengthOfLastWord(string s)
    {
        string lastString = s.Trim().Split(" ").Last();
        return lastString.Length;
    }
    //Plus One
    //You are given a large integer represented as an integer array digits, where each digits[i] is the ith digit of
    //the integer. The digits are ordered from most significant to least significant in left-to-right order. The large
    //integer does not contain any leading 0's.
    public int[] PlusOne(int[] digits)
    {
        int n = digits.Length;
        for (int i = n - 1; i >= 0; i--)
        {
            if (digits[i] < 9)
            {
                digits[i]++;
                return digits;
            }
            digits[i] = 0;
        }
        int[] newNumber = new int[n + 1];
        newNumber[0] = 1;

        return newNumber;
    }
    
}
        
    
