using Microsoft.EntityFrameworkCore;
using Northwind.Demo.Entity.Models;
using Northwind.Demo.Repository.Database;
using Northwind.Demo.Repository.IRepositories;
using System.Linq.Expressions;

namespace Northwind.Demo.Repository.Repositories
{
    public class CustomersRepository : ICustomersRepository
    {
        private readonly AppDbContext _appDbContext;
        public CustomersRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<List<Customer>> GetCustomersAsync(Expression<Func<Customer, bool>> predicate)
        {
            IQueryable<Customer> query = _appDbContext.Customers;
            return await query.Where(predicate).ToListAsync();
        }

        public async Task<List<Customer>> GetCustomersAll()
        {
            IQueryable<Customer> query = _appDbContext.Customers;
            return await query.ToListAsync();
        }
    }
}
