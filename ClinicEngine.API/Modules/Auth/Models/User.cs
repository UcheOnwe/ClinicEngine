//Blueprint 
namespace ClinicEngine.API.Modules.Auth.Models;
public class User
{
    public Guid Id {get; set; } //Not int — we chose UUID in Sprint 0. In C# a UUID is called a Guid. 
    // An int ID like 1,2,3 is predictable and guessable — anyone can hit /clinics/4 and probe your system.
    // A Guid looks like a3f8c21d-... — impossible to guess.

    public string Email {get; set;} = string.Empty;

    public string PasswordHash {get; set;} = string.Empty;

    public DateTime Email_Verified {get; set;} = DateTime.UtcNow;

}