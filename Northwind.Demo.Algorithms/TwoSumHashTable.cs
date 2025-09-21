namespace Northwind.Demo.Algorithms;

[TestClass]
public class TwoSumHashTable
{
    [TestMethod]
    public void TestMethod1()
    {
        int[] list = [2, 7, 11, 15];
        var target = 9;

        Test(list, target);
    }
    Func<int[], int, int[]> Test = (nums, target) =>
    {
        Dictionary<int, int> dic = [];
        for (int i = 0; i < nums.Length; i++)
        {
            if (dic.ContainsKey(target - nums[i]))
            {
                return [dic[target - nums[i]], i];
            }
        }
        return [];
    };
}
