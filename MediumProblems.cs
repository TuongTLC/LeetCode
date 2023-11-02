namespace LeetCode;

public class MediumProblems
{
    //***Sort Colors***
    //Given an array nums with n objects colored red, white, or blue, sort them in-place so that objects of the same
    //color are adjacent, with the colors in the order red, white, and blue.
    //We will use the integers 0, 1, and 2 to represent the color red, white, and blue, respectively.
    //You must solve this problem without using the library's sort function.
    public void SortColors(int[] nums) {
        //Bubble sort
        for (int i = 0; i < nums.Length-1; i++)
        {
            for (int j = i+1; j <  nums.Length; j++)
            {
                if (nums[i]>nums[j])
                {
                    (nums[j], nums[i]) = (nums[i], nums[j]);
                }
            }
        }
    }
    //***Single Number II***
    //Given an integer array nums where every element appears three times except for one, which appears exactly once.
    //Find the single element and return it.
    public int SingleNumber(int[] nums)
    {
        Array.Sort(nums);
        for (int i = 0; i < nums.Length;)
        {
            if (i < nums.Length - 2)
            {
                if (nums[i] == nums[i + 1] && nums[i] == nums[i + 2])
                {
                    i += 3;
                    continue; 
                }
                return nums[i];
            }
            return nums[nums.Length - 1];
        }
        return -1;
    }
}