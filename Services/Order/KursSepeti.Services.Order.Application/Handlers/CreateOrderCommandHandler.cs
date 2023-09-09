using KursSepeti.Services.Order.Application.Commands;
using KursSepeti.Services.Order.Application.Dtos;
using KursSepeti.Services.Order.Domain.OrderAggregate;
using KursSepeti.Services.Order.Infrastructure;
using KursSepeti.Shared.Dtos;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace KursSepeti.Services.Order.Application.Handlers
{
    public class CreateOrderCommandHandler : IRequestHandler<CreateOrderCommand, Response<CreatedOrderDto>>
    {
        private readonly OrderDbContext _dbContext;

        public CreateOrderCommandHandler(OrderDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Response<CreatedOrderDto>> Handle(CreateOrderCommand request, CancellationToken cancellationToken)
        {
            var newAdress = new Address(request.AddressDto.Province, request.AddressDto.District, request.AddressDto.Street, request.AddressDto.ZipCode, request.AddressDto.Line);
            Domain.OrderAggregate.Order newOrder = new Domain.OrderAggregate.Order(request.BuyurId, newAdress);

            request.OrderItems.ForEach(x =>
                {
                    newOrder.AddOrderItem(x.ProductId, x.ProductName, x.Price, x.PictureUrl);
                }
            );

            await _dbContext.Orders.AddAsync(newOrder);
            await _dbContext.SaveChangesAsync();

            return Response<CreatedOrderDto>.Success(new CreatedOrderDto { OrderId = newOrder.Id },200);
        }

       
    }
}
