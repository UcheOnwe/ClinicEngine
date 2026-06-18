namespace ClinicEngine.Modules.Booking.DTOs;

public class CreateAppointmentRequest
{
    public Guid ClinicId { get; set; } = Guid.Empty;
    public Guid PetId { get; set; } = Guid.Empty;
    public Guid SlotId { get; set; } = Guid.Empty;
    public Guid ServiceId { get; set; } = Guid.Empty;
    public string Status { get; set; } = string.Empty;
    public string Channel { get; set; } = string.Empty;
    public bool AiHandled { get; set; } = false;

}