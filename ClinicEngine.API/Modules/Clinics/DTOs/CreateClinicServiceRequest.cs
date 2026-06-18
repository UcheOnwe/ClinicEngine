namespace ClinicEngine.Modules.Clinics.DTOs;

public class CreateClinicServiceRequest
{
    public Guid ClinicId { get; set; } = Guid.Empty;
    public string Name { get; set; } = string.Empty;
    public int Duration { get; set; } = 0;
    public bool IsActive { get; set; } = false;

}