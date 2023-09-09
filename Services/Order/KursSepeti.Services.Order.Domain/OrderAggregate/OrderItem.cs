using KursSepeti.Services.Order.Domain.Core;

namespace KursSepeti.Services.Order.Domain.OrderAggregate
{
    public class OrderItem : Entity
    {
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public string PictureUrl { get; set; }
        public decimal Price { get; set; }

        public OrderItem() { }
        public OrderItem(string productId, string productName, string pictureUrl, decimal price)
        {
            ProductId = productId;
            ProductName = productName;
            PictureUrl = pictureUrl;
            Price = price;
        }

        public void UpdateOrderItem(string productName, string pictureUrl, decimal price)
        {
            ProductName = productName;
            PictureUrl = pictureUrl;
            Price = price;
        }
    }
}
