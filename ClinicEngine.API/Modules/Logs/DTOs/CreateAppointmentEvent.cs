namespace ClinicEngine.Modules.Logs.DTOs;

public class CreateAppointmentEventRequest
{
    public Guid AppointmentId {get; set; }
    public string event_type { get; set; } = string.Empty;
    public string triggered_by {get; set;} = string.Empty;
    public string Metadata { get; set; } = "{}";

}