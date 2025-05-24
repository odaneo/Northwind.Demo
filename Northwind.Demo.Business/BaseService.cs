using AutoMapper;
using Microsoft.Extensions.Logging;

namespace Northwind.Demo.Business
{
    public class BaseService<TService> where TService : class
    {
        protected readonly IMapper _mapper;
        protected readonly ILogger<TService> _logger;
        protected BaseService(IMapper mapper, ILogger<TService> logger)
        {
            _mapper = mapper;
            _logger = logger;
        }
    }
}
