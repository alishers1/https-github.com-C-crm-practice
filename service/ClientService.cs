using Crm.Entities; 
using Crm.Validate;
namespace Crm.Services;


public sealed class ClientService
{
    public Client CreateClient(
        string firstName,
        string lastName,
        string middleName,
        short age, 
        string passportNumber, 
        string gender
    )

    {
        Client newClient = new Client
        {
            FirstName = firstName,
            LastName = lastName,
            MiddleName = middleName,
            Age = age,
            PassportNumber = passportNumber,
            Gender = gender
        };

        if (!Validation.ValidateClient(newClient))
        {
            return null;
        }


        return newClient;
    }
}
