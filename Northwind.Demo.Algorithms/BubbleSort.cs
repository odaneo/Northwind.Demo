namespace Northwind.Demo.Algorithms;

[TestClass]
public class BubbleSort
{
    [TestMethod]
    public void TestMethod1()
    {
        List<int> list = new() { 3, 4, 8, 6, 1, 1, 8 };

        for (var i = 0; i < list.Count; i++)
        {
            for (var j = 0; j < list.Count - i - 1; j++)
            {
                if (list[j] > list[j + 1])
                {
                    (list[j], list[j + 1]) = (list[j + 1], list[j]);
                }
            }
        }
    }
}
