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

            Test(list, new List<int>(), true);
            Test(list, new List<int>(), false);

            foreach (var perm in result)
            {
                Console.WriteLine(string.Join(",", perm));
            }

        }
        public string Test222(string restString)
        {
            if (restString.Length <= 1)
            {
                return restString;
            }
            return restString.Last() + Test222(restString.Substring(0, restString.Length - 1));
        }
        public void Test(List<int> list, List<int> currentList, bool isGo)
        {
            if (list.Count == 0)
            {
                result.Add(new List<int>(currentList));
                return;
            }

            int head = list[0];

            var nextRest = new List<int>(list);
            nextRest.RemoveAt(0);

            if (isGo)
            {
                var nextCurr = new List<int>(currentList);
                nextCurr.Add(head);
                Test(nextRest, nextCurr, true);
                Test(nextRest, nextCurr, false);
            }
            else
            {
                Test(nextRest, currentList, true);
                Test(nextRest, currentList, false);
            }
        }
    }
}
