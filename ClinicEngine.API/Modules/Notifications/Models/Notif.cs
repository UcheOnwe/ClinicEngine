//Blueprint 
namespace ClinicEngine.API.Modules.Notifications.Models;
public class Notif
{
    public Guid Id {get; set; } //Not int — we chose UUID in Sprint 0. In C# a UUID is called a Guid. 
    // An int ID like 1,2,3 is predictable and guessable — anyone can hit /clinics/4 and probe your system.
    // A Guid looks like a3f8c21d-... — impossible to guess.

    public Guid ClientId {get; set; }
    public Guid AppointmentId {get; set; }

    public string Channel { get; set; } = string.Empty;
    public string type { get; set; } = string.Empty;
    public string status { get; set; } = string.Empty;
    public DateTime sent_at {get; set;} = DateTime.MinValue;
}