//Blueprint 
namespace ClinicEngine.API.Modules.Clients.Models;
public class Clients
{
    public Guid Id {get; set; } //Not int — we chose UUID in Sprint 0. In C# a UUID is called a Guid. 
    // An int ID like 1,2,3 is predictable and guessable — anyone can hit /clinics/4 and probe your system.
    // A Guid looks like a3f8c21d-... — impossible to guess.

    public Guid ClinicID {get; set; }

    public string Name { get; set; } = string.Empty;

    public string PhoneNumber {get; set;} = string.Empty;

    public string Email {get; set;} = string.Empty;

    public string Pref_Channel {get; set;} = string.Empty;

    public DateTime Timestamp { get; set; } = DateTime.UtcNow;

}