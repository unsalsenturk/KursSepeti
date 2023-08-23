using AutoMapper;
using KursSepeti.Services.Order.Application.Dtos;
using KursSepeti.Services.Order.Domain.OrderAggregate;

namespace KursSepeti.Services.Order.Application.Mapping
{
    public class CustomMapping : Profile
    {
        public CustomMapping()
        {
            CreateMap<Domain.OrderAggregate.Order, OrderDto>().ReverseMap();
            CreateMap<OrderItem, OrderItemDto>().ReverseMap();
            CreateMap<Address, AddressDto>().ReverseMap();
        }
    }
}
