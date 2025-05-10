namespace Northwind.Demo.Server.Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {

            int[] nums = { 1, 3, 2, 5, 1, 1, 2 };
            int target = 8;

            int index1 = 0;
            int index2 = 0;
            int sum = 0;

            while (index1 < nums.Length)
            {
                sum += nums[index2];
                while (sum > target && index1 <= index2)
                {
                    sum -= nums[index1];
                    index1++;
                }
                if (sum == target)
                {
                    Console.WriteLine($"Found: {index1} - {index2}");
                    return;
                }
                index2++;
            }

        }
    }
}
