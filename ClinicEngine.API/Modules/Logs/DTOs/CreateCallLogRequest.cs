namespace ClinicEngine.Modules.Logs.DTOs;

public class CreateCallLogRequest
{
    public Guid ClinicId { get; set; }
    public Guid ClientId { get; set; }
    public Guid AppointmentId { get; set; }

    public string caller_phone { get; set; } = string.Empty;

    public string intent_type {get; set;} = string.Empty;
    public string outcome {get; set;} = string.Empty;
    public bool ai_handled {get; set;} = false;
    public int duration_sec {get; set;} = 0;


}