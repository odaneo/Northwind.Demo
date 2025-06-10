namespace Northwind.Demo.Algorithms;

[TestClass]
public class MergeSort
{
    [TestMethod]
    public void TestMethod()
    {
        List<int> nums = new List<int> { 5, 3, 1, 4, 2 };

        MergeSort2(nums, 0, nums.Count - 1);

        Console.WriteLine(string.Join(", ", nums));
    }
    static void MergeSort2(List<int> nums, int left, int right)
    {
        if (left >= right) return;

        int mid = (left + right) / 2;

        // 递归排序左右两部分
        MergeSort2(nums, left, mid);
        MergeSort2(nums, mid + 1, right);

        // 合并两个有序部分
        Merge(nums, left, mid, right);
    }
    // 合并两个有序子数组 [left..mid] 和 [mid+1..right]
    static void Merge(List<int> nums, int left, int mid, int right)
    {
        List<int> temp = new List<int>();

        int i = left;
        int j = mid + 1;

        // 双指针合并两个有序段
        while (i <= mid && j <= right)
        {
            if (nums[i] <= nums[j])
                temp.Add(nums[i++]);
            else
                temp.Add(nums[j++]);
        }

        // 剩下左边的
        while (i <= mid)
            temp.Add(nums[i++]);

        // 剩下右边的
        while (j <= right)
            temp.Add(nums[j++]);

        // 把 temp 中的值复制回原数组
        for (int k = 0; k < temp.Count; k++)
        {
            nums[left + k] = temp[k];
        }
    }
}
