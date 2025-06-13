namespace Northwind.Demo.Algorithms;

[TestClass]
public class QuickSort
{
    [TestMethod]
    public void TestMethod1()
    {
        List<int> nums = new List<int> { 5, 3, 1, 4, 2 };
        QuickSort2(nums, 0, nums.Count - 1);
        Console.WriteLine(string.Join(", ", nums));  // 输出：1, 2, 3, 4, 5
    }
    // 快速排序主函数，排序 nums[left..right]
    static void QuickSort2(List<int> nums, int left, int right)
    {
        if (left >= right) return;

        // 获取分区点，划分数组，返回基准元素位置
        int pivotIndex = Partition(nums, left, right);

        // 递归排序基准左边部分
        QuickSort2(nums, left, pivotIndex - 1);

        // 递归排序基准右边部分
        QuickSort2(nums, pivotIndex + 1, right);
    }

    // 分区函数，返回基准元素最终位置
    static int Partition(List<int> nums, int left, int right)
    {
        int pivot = nums[right];  // 以最后一个元素为基准
        int i = left - 1;         // i 表示小于等于基准元素的区间尾部

        for (int j = left; j < right; j++)
        {
            if (nums[j] <= pivot)
            {
                i++;
                Swap(nums, i, j);
            }
        }

        // 把基准元素放到正确位置
        Swap(nums, i + 1, right);

        return i + 1;  // 返回基准元素的位置
    }

    // 交换函数
    static void Swap(List<int> nums, int i, int j)
    {
        int temp = nums[i];
        nums[i] = nums[j];
        nums[j] = temp;
    }
}
