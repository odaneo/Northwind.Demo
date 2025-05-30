namespace Northwind.Demo.Server.Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var input = new Dictionary<string, object>
            {
                { "a", 5 },
                { "b", new Dictionary<string, object>
                    {
                        { "c", 10 },
                        { "d", new Dictionary<string, object>
                            {
                                { "e", 15 }
                            }
                        }
                    }
                },
                { "f", "hello" }
            };
        }
        public static int SumNestedValues(Dictionary<string, object> input)
        {
            int sum = 0;
            foreach (var key in input)
            {
                switch (key.Value)
                {
                    case int:
                        sum += (int)key.Value;
                        break;
                    case Dictionary<string, object>:
                        sum += SumNestedValues((Dictionary<string, object>)key.Value);
                        break;
                    default:
                        break;
                }
            }
            return sum;
        }
    }
}
