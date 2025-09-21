namespace Northwind.Demo.Algorithms;

[TestClass]
public class BinarySearchInsertion
{
    [TestMethod]
    public void TestMethod()
    {
        var nums = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        int target = 5;
        var result = Test(nums, target);
        Console.WriteLine(result);
    }
    Func<List<int>, int, int> Test = (nums, target) =>
    {
        var left = 0;
        var right = nums.Count - 1;
        while (left <= right)
        {
            var mid = left + (right - left) / 2;
            if (nums[mid] > target)
            {
                right = mid - 1;
            }
            else if (nums[mid] < target)
            {
                left = mid + 1;
            }
            else
            {
                return mid;
            }
        }
        return -1;
    };
}
