namespace Crm.Entities;


public sealed class Client 
{
    private string _firstName;
    private string _lastName;
    private short? _age;
    private string _gender;
    private string _phone;
    private string _email;
    private string _password;


    public required string? FirstName { 
        get => _firstName ?? string.Empty; 
        init => _firstName = value is { Length: > 0} ? value : throw new ArgumentOutOfRangeException(nameof(value)); 
    }
    public required string? LastName {
        get => _firstName ?? string.Empty; 
        init => _firstName = value is { Length: > 0} ? value : throw new ArgumentOutOfRangeException(nameof(value));
    }
    public string? MiddleName { get; init; }
    public short? Age {
        get => _age; 
        init => _age = value > 18 ? value : throw new ArgumentException("Age is lower than 18!");
    }
    public required string? PassportNumber { get; init; }
    public string? Gender {
        get => _gender ?? string.Empty; 
        init => _gender = value == "Male" || value == "Female" ? value : throw new ArgumentException("Gender must be either 'Male' or 'Female'.");
    }
    public required string Email {
        get => _email ?? string.Empty;
        init => _email = !IsValidEmail(value) ? throw new ArgumentException("Invalid email format.") : value;
    }
    public required string Password {
        get => _password ?? string.Empty;
        init => _password = !IsValidPassword(value) ? throw new ArgumentException("Invalid password format.") : value;
    }
    public required string Phone {
        get => _phone ?? string.Empty; 
        init {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Phone can't be empty or contain only spaces");
            }
            foreach (char c in value)
            {
                if (!char.IsDigit(c) && c != '+')
                {
                    throw new ArgumentException("Phone can contain only numbers and + symbol");
                }
            }
            if (value.Length > 15)
            {
                throw new ArgumentException("Phone can't be more than 15 elements");
            }

            _phone = value;
        }
    } 
    
    public override string ToString()
    {
        return $"Client Name: {FirstName} {LastName}\n" + 
               $"Middle Name: {MiddleName}\n" +
               $"Age: {Age}\n" + 
               $"Passport Number: {PassportNumber}\n" + 
               $"Gender: {Gender}";
    }

    private bool IsValidEmail(string email)
    {
        return email.Contains("@");
    }

    private bool IsValidPassword(string password)
    {
        string pattern = "^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)(?=.*[@#$%^&+=!])(?=.{8,})";
        return Regex.IsMatch(password, pattern);
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