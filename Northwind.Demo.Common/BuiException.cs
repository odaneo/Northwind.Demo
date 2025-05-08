namespace Northwind.Demo.Common
{
    public class BuiException : Exception
    {
        public string Code { get; }
        public BuiException(string code, string message) : base(message)
        {
            Code = code;
        }
    }
}
