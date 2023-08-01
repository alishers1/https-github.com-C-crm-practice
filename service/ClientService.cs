using Crm.Entities; 
using Crm.Validate;
namespace Crm.Services;


public sealed class ClientService
{
    private List<Client> clients = new();
    public Client CreateClient(ClientInfo clientInfo)
    {
        Client newClient = new Client("Alisher", "Siddiqov", 23)
        {
            FirstName = clientInfo.FirstName,
            LastName = clientInfo.LastName,
            MiddleName = clientInfo.MiddleName,
            Age = clientInfo.Age,
            PassportNumber = clientInfo.PassportNumber,
            Gender = clientInfo.Gender
        };

        if (!Validation.ValidateClient(newClient))
        {
            return null;
        }

        clients.Add(newClient);

        return newClient;
    }
}
