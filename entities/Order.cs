namespace Crm.Entities;

public sealed class Order 
{
    public int ID { get; set; }
    public string? Description { get; set; }
    public double Price { get; set; }
    public DateTime Date { get; set; }
    public string? Delivery { get; set; }
    public string? Address { get; set; }

    public override string ToString()
    {
        return $"Order ID: {ID}\n" + 
               $"Description: {Description}\n" +
               $"Price: {Price}\n" + 
               $"Date: {Date}\n" + 
               $"Delivery: {Delivery}" +
               $"Address: {Address}";
    }
}

public readonly struct OrderInfo
{
    public readonly int ID {get; init;}
    public readonly string Description  {get; init;}
    public readonly double Price {get; init;}
    public readonly DateTime Date  {get; init;}
    public readonly string Delivery  {get; init;}
    public readonly string Address  {get; init;}

    public OrderInfo(
        int id,
        string description,
        double price,
        DateTime date, 
        string delivery,
        string address
    )
    {
        ID = id;
        Description = description;
        Price = price;
        Date = date;
        Delivery = delivery;
        Address = address;

    }
}
