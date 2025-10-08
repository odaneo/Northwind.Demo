namespace Northwind.Demo.Algorithms;

[TestClass]
public class SelectionSort
{
    [TestMethod]
    public void TestMethod()
    {
        List<int> nums = [3, 5, 1, 2, 6, 9];

        var result = Sort(nums);

        Console.WriteLine(string.Join(",", result));
    }
    private readonly Func<List<int>, List<int>> Sort = (list) =>
    {
        for (var i = 0; i < list.Count; i++)
        {
            var maxIndex = 0;
            for (var j = 1; j < list.Count - i; j++)
            {
                if (list[maxIndex] < list[j])
                {
                    maxIndex = j;
                }
            }
            (list[list.Count - 1 - i], list[maxIndex]) = (list[maxIndex], list[list.Count - 1 - i]);
        }
        return list;
    };
}
