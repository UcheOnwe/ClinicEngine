namespace ClinicEngine.Modules.Notifications.DTOs;

public class CreateNotifRequest
{
    public Guid ClientId {get; set; }
    public Guid AppointmentId {get; set; }
    public string Channel { get; set; } = string.Empty;
    public string type { get; set; } = string.Empty;
    public string status { get; set; } = string.Empty;

}