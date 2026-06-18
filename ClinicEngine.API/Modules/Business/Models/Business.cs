//Blueprint 
namespace ClinicEngine.API.Modules.Business.Models;
public class Business
{
    public Guid Id {get; set; } //Not int — we chose UUID in Sprint 0. In C# a UUID is called a Guid. 
    // An int ID like 1,2,3 is predictable and guessable — anyone can hit /clinics/4 and probe your system.
    // A Guid looks like a3f8c21d-... — impossible to guess.
    public Guid UserId {get; set; }
    public string business_type {get; set;} = string.Empty;
    public string name {get; set;} = string.Empty;
    public string slug {get; set;} = string.Empty;
    public string status {get; set;} = string.Empty;
    public DateTime created_at {get; set;} = DateTime.UtcNow;

}