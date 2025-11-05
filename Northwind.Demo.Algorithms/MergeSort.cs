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

        MergeSort2(nums, left, mid);
        MergeSort2(nums, mid + 1, right);

        Merge(nums, left, mid, right);

    }
    static void Merge(List<int> nums, int left, int mid, int right)
    {
        List<int> temp = [];

        int i = left;
        int j = mid + 1;
        while (i <= mid && j <= right)
        {
            if (nums[i] < nums[j])
            {
                temp.Add(nums[i]);
                i++;
            }
            else
            {
                temp.Add(nums[j]);
                j++;
            }
        }

        while (i <= mid)
        {
            temp.Add(nums[i]);
            i++;
        }
        while (j <= mid)
        {
            temp.Add(nums[j]);
            j++;
        }

        for (int k = 0; k < temp.Count; k++)
        {
            nums[left + k] = temp[k];
        }
    }
}
