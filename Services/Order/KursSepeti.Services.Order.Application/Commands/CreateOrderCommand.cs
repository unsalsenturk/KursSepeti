using KursSepeti.Services.Order.Application.Dtos;
using KursSepeti.Shared.Dtos;
using MediatR;
using System.Collections.Generic;

namespace KursSepeti.Services.Order.Application.Commands
{
    public class CreateOrderCommand : IRequest<Response<CreatedOrderDto>>
    {
        public string BuyurId { get; set; }
        public List<OrderItemDto> OrderItems { get; set; }
        public AddressDto AddressDto { get; set; }
    }
}
