using System.Text;

var result = ThreeSum([0, 0, 0]);
Display(result);//[[-1,-1,2],[-1,0,1]]


result = ThreeSum([-1, 0, 1, 2, -1, -4]);
Display(result); //Output: []


result = ThreeSum([0, 1, 1]);
Display(result); //[[0,0,0]]
//https://leetcode.com/problems/3sum/description/
void Display(IList<IList<int>> listOfLists)
{
    StringBuilder sb = new();
    sb.Append("[");
    for(int i = 0; i < listOfLists.Count; ++i)
    {
        sb.Append("[");
        sb.Append((string.Join(", ", listOfLists[i])));
        sb.Append("]");

        if (i < listOfLists.Count - 1) sb.Append(", ");
    }

    sb.Append("]");
    string output = sb.ToString();
    if(output.Length > 2) output = output.Substring(0, output.Length - 1);

    Console.WriteLine($"{output}");
}

IList<IList<int>> ThreeSum(int[] nums)
{
    List<IList<int>> list = new List<IList<int>>();

    Array.Sort(nums);
    for (int i = 0; i < nums.Length - 2; ++i)
    {
        if (i > 0 && i < nums.Length && nums[i] == nums[i - 1]) ++i;
        int left = i + 1;
        int right = nums.Length - 1;

        while (left < right)
        {
            int total = nums[i] + nums[left] + nums[right];
            if (nums[i] + nums[left] + nums[right] == 0)
            {
                list.Add(new List<int> { nums[i], nums[left], nums[right] });
                ++left;
                --right;
                while (left < right && nums[left] == nums[left - 1]) ++left;
                while (left < right && nums[right] == nums[right + 1]) --right;
            }
            else if (total < 0)
            {
                ++left;
            }
            else
            {
                --right;
            }
        }
    }

    return list;
}
