using Crm.Entities;
namespace Crm.Services;

public sealed class OrderService
{
    public Order CreateOrder(OrderInfo orderInfo)
    {
        Order newOrder = new Order
        {
            ID = orderInfo.ID,
            Description = orderInfo.Description,
            Price = orderInfo.Price,
            Date = orderInfo.Date,
            Delivery = orderInfo.Delivery,
            Address = orderInfo.Address,
        };

        return newOrder;
    }
}