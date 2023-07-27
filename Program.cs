using Crm.Entities; 
using Crm.Services;

Console.WriteLine("Enter the command (Create Client or Create Order): ");

string? cmd = Console.ReadLine();

ClientService clientService = new();
OrderService orderService = new();

if (cmd.Equals("Create client", StringComparison.OrdinalIgnoreCase))
{
    Console.Write("Enter client name: ");
    string? firstName = Console.ReadLine();

    Console.Write("Enter client lastname: ");
    string? lastName = Console.ReadLine();

    Console.Write("Enter client middlename: ");
    string? middleName = Console.ReadLine();

    Console.Write("Enter client age: ");
    short age = short.Parse(Console.ReadLine());

    Console.Write("Enter client passport number: ");
    string? passportNumber = Console.ReadLine();

    Console.Write("Enter client gender: ");
    string? gender = Console.ReadLine();

    ClientInfo clientInfo = new ClientInfo(
        firstName,
        lastName,
        middleName,
        age,
        passportNumber,
        gender
    );

    Client newClient = clientService.CreateClient(clientInfo);

    Console.WriteLine("\n" + newClient);
}

if (cmd.Equals("Create order", StringComparison.OrdinalIgnoreCase))
{
    Console.Write("Enter order ID: ");
    int id = int.Parse(Console.ReadLine());

    Console.Write("Enter order description: ");
    string? description = Console.ReadLine();

    Console.Write("Enter order price: ");
    double price = double.Parse(Console.ReadLine());

    Console.Write("Enter order date: ");
    DateTime date = DateTime.Parse(Console.ReadLine());

    Console.Write("Enter order delivery status: ");
    string? delivery = Console.ReadLine();

    Console.Write("Enter order address: ");
    string? address = Console.ReadLine();

    OrderInfo orderInfo = new OrderInfo(
        id,
        description,
        price,
        date,
        delivery,
        address
    );

    Order newOrder = orderService.CreateOrder(orderInfo);

    Console.WriteLine("\n" + newOrder);
}



