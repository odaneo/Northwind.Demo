namespace Northwind.Demo.Server.Test
{
    [TestClass]
    public sealed class Test1
    {
        private List<List<int>> result = new List<List<int>>();
        [TestMethod]
        public void TestMethod1()
        {
            List<int> list = [1, 2, 3];

            Test(list, []);
            foreach (var perm in result)
            {
                Console.WriteLine(string.Join(",", perm));
            }

        }
        public void Test(List<int> restList, List<int> currentList)
        {
            var n = restList.Count;
            if (n == 0)
            {
                result.Add(currentList);
                return;
            }
            for (var i = 0; i < restList.Count; i++)
            {
                var nextRest = new List<int>(restList);
                nextRest.RemoveAt(i);

                var nextCurrent = new List<int>(currentList);
                nextCurrent.Add(restList[i]);

                Test(nextRest, nextCurrent);
            }
        }
    }
}
