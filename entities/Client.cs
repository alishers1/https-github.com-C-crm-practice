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