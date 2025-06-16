namespace Northwind.Demo.Algorithms;

[TestClass]
public class SelectionSort
{
    [TestMethod]
    public void TestMethod1()
    {
        List<int> nums = [3, 5, 1, 2, 6, 9];
        for (var i = 0; i < nums.Count; i++)
        {
            var min = i;

            for (var j = i + 1; j < nums.Count; j++)
            {
                if (nums[j] < nums[min])
                {
                    min = j;
                }
            }
            if (min != i)
            {
                (nums[i], nums[min]) = (nums[min], nums[i]);
            }
        }
    }
}
