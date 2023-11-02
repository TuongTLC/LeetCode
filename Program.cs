using LeetCode;

EasyProblems easyProblems = new EasyProblems();
MediumProblems mediumProblems = new MediumProblems();
//***TwoSum***
// int[] nums = {3,3};
// int[] output = easyProblems.TwoSum(nums, 6);
// Console.WriteLine(output[0]+","+output[1]);


//***Length of Last Word***
// string s = "   fly me   to   the moon  ";
// Console.WriteLine(easyProblems.LengthOfLastWord(s));

//***Plus One***
// int[] digits = {7,9};
// int[] output = easyProblems.PlusOne(digits);
// foreach (var num in output)
// {
//     Console.Write(num);
// }

//***Reverse Integer***
// int x = -123;
// Console.WriteLine(easyProblems.Reverse(x));

//***Search Insert Position***
// int[] nums = { 1, 3, 5, 6 };
// Console.WriteLine(easyProblems.SearchInsert(nums, 2));

//***Sort Colors***
// int[] nums = {2,0,2,1,1,0};
// mediumProblems.SortColors(nums);
// foreach (var n in nums)
// {
//     Console.WriteLine(n);
// }

//***Single Number II***
int[] nums = { 2,2,3,2 };
Console.WriteLine(mediumProblems.SingleNumber(nums));
