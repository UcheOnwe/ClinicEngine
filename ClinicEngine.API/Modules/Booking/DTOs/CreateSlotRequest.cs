namespace ClinicEngine.Modules.Booking.DTOs;

public class CreateSlotRequest
{
    public Guid ClinicId { get; set; } = Guid.Empty;
    public Guid StaffId { get; set; } = Guid.Empty;
    public Guid SlotId { get; set; } = Guid.Empty;
    public DateTime StartTime { get; set; } = DateTime.UtcNow;
    public DateTime EndTime { get; set; } = DateTime.UtcNow;

}