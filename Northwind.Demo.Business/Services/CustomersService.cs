using AutoMapper;
using Northwind.Demo.Business.IServices;
using Northwind.Demo.Common.Dtos;
using Northwind.Demo.Repository.IRepositories;

namespace Northwind.Demo.Business.Services
{
    public class CustomersService : ICustomersService
    {
        private readonly ICustomersRepository _customersRepository;
        private readonly IMapper _mapper;
        public CustomersService(ICustomersRepository customersRepository, IMapper mapper)
        {
            _customersRepository = customersRepository;
            _mapper = mapper;
        }
        public async Task<List<CustomerDto>> GetCustomersFromLondon()
        {
            var list = await _customersRepository.GetCustomersAsync((cm) => cm.City == "London");
            return _mapper.Map<List<CustomerDto>>(list);
        }
    }
}
