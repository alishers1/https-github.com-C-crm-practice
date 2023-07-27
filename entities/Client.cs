namespace Crm.Entities; 

public sealed class Client 
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? MiddleName { get; set; }
    public short? Age { get; set; }
    public string? PassportNumber { get; set; }
    public string? Gender { get; set; }

    public override string ToString()
    {
        return $"Client Name: {FirstName} {LastName}\n" + 
               $"Middle Name: {MiddleName}\n" +
               $"Age: {Age}\n" + 
               $"Passport Number: {PassportNumber}\n" + 
               $"Gender: {Gender}";
    }
}

public readonly struct ClientInfo
{
    public readonly string FirstName {get; init;}
    public readonly string LastName  {get; init;}
    public readonly string MiddleName {get; init;}
    public readonly short Age  {get; init;}
    public readonly string PassportNumber  {get; init;}
    public readonly string Gender  {get; init;}

    public ClientInfo(
        string firstName,
        string lastName,
        string middleName,
        short age, 
        string passportNumber,
        string gender
    )
    {
        FirstName = firstName;
        LastName = lastName;
        MiddleName = middleName;
        Age = age;
        PassportNumber = passportNumber;
        Gender = gender;
    }
}