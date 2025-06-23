namespace Northwind.Demo.Algorithms;

[TestClass]
public class BinarySearch
{
    public int Search(List<int> nums, int target)
    {
        var left = 0;
        var right = nums.Count - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (nums[mid] < target)
            {
                left = mid + 1;
            }
            else if (nums[mid] > target)
            {
                right = mid - 1;
            }
            else
            {
                return mid;
            }
        }
        return -1;
    }
}
