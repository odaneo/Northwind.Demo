using AutoMapper;
using Microsoft.Extensions.Logging;
using Northwind.Demo.Business.IServices;
using Northwind.Demo.Common.Dtos;
using Northwind.Demo.Repository.IRepositories;

namespace Northwind.Demo.Business.Services
{
    public class CustomersService : BaseService<CustomersService>, ICustomersService
    {
        private readonly ICustomersRepository _customersRepository;
        public CustomersService(ICustomersRepository customersRepository, IMapper mapper, ILogger<CustomersService> logger) : base(mapper, logger)
        {
            _customersRepository = customersRepository;
        }
        public async Task<List<CustomerDto>> GetCustomersFromLondon()
        {
            var list = await _customersRepository.FindAsync((cm) => cm.City == "London");
            _logger.LogInformation("Query Start");
            return _mapper.Map<List<CustomerDto>>(list);
        }
    }
}
