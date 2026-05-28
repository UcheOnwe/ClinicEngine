//Blueprint 
namespace ClinicEngine.API.Modules.Clinics.Models;
public class ClinicProfile
{
    public Guid Id {get; set; } //Not int — we chose UUID in Sprint 0. In C# a UUID is called a Guid. 
    // An int ID like 1,2,3 is predictable and guessable — anyone can hit /clinics/4 and probe your system.
    // A Guid looks like a3f8c21d-... — impossible to guess.

    public Guid businessId {get; set; }

    public string businessName {get; set;} = string.Empty;

    public string phoneNumber {get; set;} = string.Empty;

    public string Address {get; set;} = string.Empty;

    public string slug {get; set;} = string.Empty; 
    //The URL-safe booking link identifier — e.g. "paws-vet". 
    // Used to build app.domain.com/book/paws-vet

    public string status { get; set; } = string.Empty;

    public string OpeningHours { get; set; } = string.Empty;

    public string AnimalsSeen { get; set; } = string.Empty;

    public DateTime CreatedAt { get; set; } 
}