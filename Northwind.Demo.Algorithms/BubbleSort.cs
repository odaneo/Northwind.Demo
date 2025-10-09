namespace Northwind.Demo.Algorithms;

[TestClass]
public class BubbleSort
{
    [TestMethod]
    public void TestMethod()
    {
        List<int> list = new() { 3, 4, 8, 6, 1, 1, 8 };

        var l = Sort(list);

        Console.WriteLine(string.Join(",", l));
    }
    Func<List<int>, List<int>> Sort = (nums) =>
    {
        for (var i = 0; i < nums.Count - 1; i++)
        {
            for (var p = 1; p < nums.Count - i; p++)
            {
                if (nums[p] < nums[p - 1])
                {
                    (nums[p], nums[p - 1]) = (nums[p - 1], nums[p]);
                }
            }
        }
        return nums;
    };
}
