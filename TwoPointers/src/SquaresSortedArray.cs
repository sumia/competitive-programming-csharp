//https://leetcode.com/problems/squares-of-a-sorted-array/description/

public class SquaresSortedArray
{
    public int[] Solve(int[] nums)
    {
        int n = nums.Length;

        int[] result = new int[n];

        int left = 0;
        int right = n - 1;

        for (int i = n - 1; i >= 0; --i)
        {
            int square = 0;
            if (Math.Abs(nums[left]) > Math.Abs(nums[right]))
            {
                square = nums[left];
                ++left;
            }
            else if (Math.Abs(nums[left]) < Math.Abs(nums[right]))
            {
                square = nums[right];
                --right;
            }

            result[i] = square * square;
        }

        return result;
    }
}