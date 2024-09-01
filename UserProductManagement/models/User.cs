using Microsoft.AspNetCore.Identity;

public class User : IdentityUser
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string Gender { get; set; }

    public User()
    {
        // Default values or you can use constructor parameters if needed
        FirstName = string.Empty;
        LastName = string.Empty;
        Gender = string.Empty;
    }

    public User(string firstName, string lastName, DateTime dateOfBirth, string gender)
    {
        FirstName = firstName;
        LastName = lastName;
        DateOfBirth = dateOfBirth;
        Gender = gender;
    }
}
