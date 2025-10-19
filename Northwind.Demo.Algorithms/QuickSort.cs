namespace Northwind.Demo.Algorithms;

[TestClass]
public class QuickSort
{
    [TestMethod]
    public void TestMethod()
    {
        List<int> nums = new List<int> { 5, 3, 1, 4, 2 };

        Sort(nums, 0, nums.Count - 1);

        Console.WriteLine(string.Join(", ", nums));
    }
    static void Sort(List<int> nums, int left, int right)
    {
        if (left >= right) return;

        int pivotIndex = Partition(nums, left, right);

        Sort(nums, left, pivotIndex - 1);

        Sort(nums, pivotIndex + 1, right);
    }
    static int Partition(List<int> nums, int left, int right)
    {
        int pivot = nums[right];
        var slow = left;

        for (int fast = left; fast < right; fast++)
        {
            if (nums[fast] <= pivot)
            {
                (nums[slow], nums[fast]) = (nums[fast], nums[slow]);
                slow++;
            }
        }

        (nums[slow], nums[right]) = (nums[right], nums[slow]);

        return slow;
    }
}
