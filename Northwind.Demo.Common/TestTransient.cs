namespace Northwind.Demo.Common
{
    public class TestTransient
    {
        public TestTransient()
        {
            Console.WriteLine("TestTransient created");
        }
        public void DoSomething()
        {
            Console.WriteLine("Doing something in TestTransient");
        }
    }
}
