//Blueprint 
namespace ClinicEngine.API.Modules.Booking.Models;
public class Slot
{
    public Guid Id {get; set; } //Not int — we chose UUID in Sprint 0. In C# a UUID is called a Guid. 
    // An int ID like 1,2,3 is predictable and guessable — anyone can hit /clinics/4 and probe your system.
    // A Guid looks like a3f8c21d-... — impossible to guess.
    public Guid ClinicID {get; set; }
    public Guid StaffID {get; set; }
    public Guid SlotID {get; set; }
    public Guid ServiceID {get; set; }
    public bool is_booked { get; set; } = false;
    public bool is_blocked { get; set; } = false;
    public DateTime created_at { get; set; } = DateTime.UtcNow;
    public DateTime start_time { get; set; } = DateTime.UtcNow;
    public DateTime end_time { get; set; } = DateTime.UtcNow;

}