namespace LeetCode;

public class EasyProblems
{
    //Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
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
}
        
    
