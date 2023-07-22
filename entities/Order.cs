namespace Crm.Entities;

public sealed class Order 
{
    public int ID { get; set; }
    public string? Description { get; set; }
    public double Price { get; set; }
    public DateTime Date { get; set; }
    public string? Delivery { get; set; }
    public string? Address { get; set; }
}
