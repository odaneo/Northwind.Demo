using Northwind.Demo.Entity.Models;
using Northwind.Demo.Repository.Database;
using Northwind.Demo.Repository.IRepositories;

namespace Northwind.Demo.Repository.Repositories
{
    public class CustomersRepository : BaseRepository<Customer>, ICustomersRepository
    {
        public CustomersRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
