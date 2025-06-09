namespace Northwind.Demo.Algorithms
{
    [TestClass]
    public sealed class InsertionSort
    {
        [TestMethod]
        public void TestMethod()
        {
            List<int> nums = [5, 3, 4, 1];

            for (var i = 1; i < nums.Count; i++)
            {
                for (var j = i; j > 0; j--)
                {
                    if (nums[j - 1] > nums[j])
                    {
                        int temp = nums[j];
                        nums[j] = nums[j - 1];
                        nums[j - 1] = temp;
                    }
                }
            }

            Console.WriteLine(string.Join(",", nums));
        }
    }
}
