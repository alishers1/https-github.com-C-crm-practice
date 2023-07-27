using Crm.Entities; 
using Crm.Validate;
namespace Crm.Services;


public sealed class ClientService
{
    public Client CreateClient(ClientInfo clientInfo)

    {
        Client newClient = new Client
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


        return newClient;
    }
}
