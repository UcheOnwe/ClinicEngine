//Blueprint 
namespace ClinicEngine.API.Modules.Logs.Models;

public class AppointmentEvent
{
    public Guid Id {get; set; } //Not int — we chose UUID in Sprint 0. In C# a UUID is called a Guid. 
    // An int ID like 1,2,3 is predictable and guessable — anyone can hit /clinics/4 and probe your system.
    // A Guid looks like a3f8c21d-... — impossible to guess.

    public Guid AppointmentId {get; set; }

    public string event_type { get; set; } = string.Empty;

    public string triggered_by {get; set;} = string.Empty;
    public string Metadata { get; set; } = "{}";
    public DateTime created_at {get; set;} = DateTime.UtcNow;
}