namespace Northwind.Demo.Algorithms;

[TestClass]
public class TwoSum
{
    [TestMethod]
    public void TestMethod()
    {
        int[] list = [2, 7, 11, 15];
        var target = 9;

        TwoSumHashTable(list, target);

        TwoSumTwoPtr(list, target);
    }
    Func<int[], int, int[]> TwoSumHashTable = (nums, target) =>
    {
        Dictionary<int, int> dic = [];
        for (int i = 0; i < nums.Length; i++)
        {
            if (dic.ContainsKey(target - nums[i]))
            {
                return [dic[target - nums[i]], i];
            }
            dic.Add(nums[i], i);
        }
        return [];
    };
    Func<int[], int, int[]> TwoSumTwoPtr = (nums, target) =>
    {
        int low = 0;
        int high = nums.Length - 1;
        while (low < high)
        {
            var sum = nums[low] + nums[high];
            if (sum < target)
            {
                low++;
            }
            else if (sum > target)
            {
                high--;
            }
            else
            {
                return [low, high];
            }
        }
        return [];
    };
}
