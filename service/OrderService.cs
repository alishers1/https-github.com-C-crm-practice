using Crm.Entities;
namespace Crm.Services;

public sealed class OrderService
{
    public Order CreateOrder(
        int id,
        string description,
        double price,
        DateTime date, 
        string delivery, 
        string address
    )
    {
        return new()
        {
            ID = id,
            Description = description,
            Price = price,
            Date = date,
            Delivery = delivery,
            Address = address
        };
    }
}