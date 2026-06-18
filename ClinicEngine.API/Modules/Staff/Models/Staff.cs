//Blueprint 
namespace ClinicEngine.API.Modules.Staff.Models;
public class Staff
{
    public Guid Id {get; set; } //Not int — we chose UUID in Sprint 0. In C# a UUID is called a Guid. 
    // An int ID like 1,2,3 is predictable and guessable — anyone can hit /clinics/4 and probe your system.
    // A Guid looks like a3f8c21d-... — impossible to guess.

    public Guid ClinicId {get; set; }

    public string Name { get; set; } = string.Empty;

    public string role {get; set;} = string.Empty;

    public Boolean is_active {get; set;} = false;
}