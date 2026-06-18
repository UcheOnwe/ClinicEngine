//Blueprint 
namespace ClinicEngine.API.Modules.Booking.Models;
public class Appointment
{
    public Guid Id {get; set; } //Not int — we chose UUID in Sprint 0. In C# a UUID is called a Guid. 
    // An int ID like 1,2,3 is predictable and guessable — anyone can hit /clinics/4 and probe your system.
    // A Guid looks like a3f8c21d-... — impossible to guess.
    public Guid ClinicID {get; set; }
    public Guid PetID {get; set; }
    public Guid SlotID {get; set; }
    public Guid ServiceID {get; set; }
    public string Status { get; set; } = string.Empty;

    public string Channel {get; set;} = string.Empty;

    public bool ai_handled {get; set;} = false;
    public DateTime created_at { get; set; } = DateTime.UtcNow;

}