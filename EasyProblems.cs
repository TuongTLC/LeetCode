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
    
    
    //***Reverse Integer***
    //Given a signed 32-bit integer x, return x with its digits reversed. If reversing x causes the value to go outside
    //the signed 32-bit integer range [-231, 231 - 1], then return 0.
    public int Reverse(int x) {
        string str = new string(x.ToString().Trim('-').Reverse().ToArray());
        bool tryInt32 = int.TryParse(str, out int intValue);
        return tryInt32 ? x.ToString().Contains("-") ? intValue * -1 : intValue : 0; 
    }
    
    
    //***Search Insert Position***
    //Given a sorted array of distinct integers and a target value, return the index if the target is found. If not,
    //return the index where it would be if it were inserted in order.
    public int SearchInsert(int[] nums, int target)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            if (target == nums[i])
            {
                return i;
            }
        }
        List<int> numL = nums.ToList();
        numL.Add(target);
        foreach (var n in numL)
        {
            Console.WriteLine(n);
        }
        numL.Sort();
        for (int i = 0; i < numL.Count; i++)
        {
            if (target == numL[i])
            {
                return i;
            }
        }
        return 0;
    }
}
        
    
