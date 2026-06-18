//Blueprint 
namespace ClinicEngine.API.Modules.Pet.Models;
public class Pet
{
    public Guid Id {get; set; } //Not int — we chose UUID in Sprint 0. In C# a UUID is called a Guid. 
    // An int ID like 1,2,3 is predictable and guessable — anyone can hit /clinics/4 and probe your system.
    // A Guid looks like a3f8c21d-... — impossible to guess.

    public Guid ClinicId {get; set; }

    public string Name { get; set; } = string.Empty;

    public string species {get; set;} = string.Empty;
    public string breed {get; set;} = string.Empty;
    public string notes {get; set;} = string.Empty; // will need to review pet-hippa policies and see if we can store notes on pets
    public DateTime dob {get; set;} = DateTime.UtcNow;
}