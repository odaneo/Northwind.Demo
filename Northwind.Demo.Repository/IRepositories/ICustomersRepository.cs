using Northwind.Demo.Entity.Models;
using System.Linq.Expressions;

namespace Northwind.Demo.Repository.IRepositories
{
    public interface ICustomersRepository
    {
        Task<List<Customer>> GetCustomersAll();
        Task<List<Customer>> GetCustomersAsync(Expression<Func<Customer, bool>> predicate);
    }
}