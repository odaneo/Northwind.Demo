namespace Northwind.Demo.Server.Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] nums = { 1, 1, 1, 2, 2, 3 };

            int n = nums.Length;
            if (n <= 2)
            {
                Console.WriteLine(n); // 原数组已满足条件
                return;
            }
            int left = 2;//左边

            for (int right = 2; right < n; right++)
            {
                if (nums[right] != nums[left - 2])
                {
                    nums[left] = nums[right];
                    left++;
                }
            }
        }
    }
}
