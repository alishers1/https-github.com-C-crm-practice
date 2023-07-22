using Crm.Entities;
namespace Crm.Validate;

public static class Validation
{
    public static bool ValidateClient(Client client)
    {
        if (string.IsNullOrWhiteSpace(client.FirstName))
        {
            Console.WriteLine("Error: The name of client can't be empty!");
            return false;
        } else if (string.IsNullOrWhiteSpace(client.LastName))
        {
            Console.WriteLine("Error: The last name of client can't be empty!");
            return false;
        } else if (client.Age == null)
        {
            Console.WriteLine("Error: The age of client can't be empty!");
            return false;
        } else if (client.Age <= 18)
        {
            Console.WriteLine("Error: The age of client can't be lower than 18!");
            return false;
        } else if (string.IsNullOrWhiteSpace(client.PassportNumber))
        {
            Console.WriteLine("Error: The passport number of client can't be empty!");
            return false;
        } else if (client.Gender != "Male" && client.Gender != "Female")
        {
            Console.WriteLine("Error: The gender should be either Male or Female!");
            return false;
        }

        return true;
    }
}