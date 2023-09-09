using KursSepeti.Services.Order.Application.Dtos;
using KursSepeti.Shared.Dtos;
using MediatR;
using System.Collections.Generic;

namespace KursSepeti.Services.Order.Application.Queries
{
    public class GetOrdersByUserIdQuery : IRequest<Response<List<OrderDto>>>
    {
        public string UserId { get; set; }
    }
}
