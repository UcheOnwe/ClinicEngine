namespace ClinicEngine.Modules.Clinics.DTOs;

public class CreateClinicRequest
{
    public string Name { get; set; } = string.Empty;
    public string PhoneNumber { get; set; } = string.Empty;

    public string Address { get; set; } = string.Empty;

    public string OpeningHours { get; set; } = string.Empty;

    public string AnimalsSeen { get; set; } = string.Empty;
}