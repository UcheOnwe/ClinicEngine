//Blueprint 
namespace ClinicEngine.API.Modules.Logs.Models;
public class CallLog
{
    public Guid Id {get; set; } //Not int — we chose UUID in Sprint 0. In C# a UUID is called a Guid. 
    // An int ID like 1,2,3 is predictable and guessable — anyone can hit /clinics/4 and probe your system.
    // A Guid looks like a3f8c21d-... — impossible to guess.

    public Guid ClinicId {get; set; }
    public Guid ClientId {get; set; }
    public Guid AppointmentId {get; set; }

    public string caller_phone { get; set; } = string.Empty;

    public string intent_type {get; set;} = string.Empty;
    public string outcome {get; set;} = string.Empty;
    public bool ai_handled {get; set;} = false;
    public int duration_sec {get; set;} = 0;
    public DateTime created_at {get; set;} = DateTime.UtcNow;
}