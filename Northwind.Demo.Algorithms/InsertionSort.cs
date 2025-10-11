namespace Northwind.Demo.Algorithms
{
    [TestClass]
    public sealed class InsertionSort
    {
        [TestMethod]
        public void TestMethod()
        {
            List<int> nums = [5, 3, 4, 1];

            Console.WriteLine(string.Join(",", Sort(nums)));
        }
        Func<List<int>, List<int>> Sort = (nums) =>
        {
            for (var p = 1; p < nums.Count; p++)
            {
                int current = nums[p];
                var j = p - 1;
                while (j >= 0 && nums[j] > current)
                {
                    nums[j + 1] = nums[j];
                    j--;
                }
                nums[j + 1] = current;
            }
            return nums;
        };
    }
}
