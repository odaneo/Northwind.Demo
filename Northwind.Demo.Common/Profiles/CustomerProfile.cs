using AutoMapper;
using Northwind.Demo.Common.Dtos;
using Northwind.Demo.Entity.Models;

namespace Northwind.Demo.Common.Profiles
{
    public class CustomerProfile : Profile
    {
        public CustomerProfile()
        {
            CreateMap<Customer, CustomerDto>().ReverseMap();
        }
    }
}
