using Northwind.Demo.Common.Dtos;
using Northwind.Demo.Entity.Models;

namespace Northwind.Demo.Business.IServices
{
    public interface ICustomersService
    {
        Task<List<CustomerDto>> GetCustomersFromLondon();
    }
}