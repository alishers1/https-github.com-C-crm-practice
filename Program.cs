using Crm.Entities; 
using Crm.Services;

Console.WriteLine("Enter the command (Create Client or Create Order): ");

string? cmd = Console.ReadLine();

ClientService clientService = new();

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

    Client newClient = clientService.CreateClient(
        firstName,
        lastName,
        middleName,
        age,
        passportNumber,
        gender
    );

    Console.WriteLine(newClient.ToString());
}



