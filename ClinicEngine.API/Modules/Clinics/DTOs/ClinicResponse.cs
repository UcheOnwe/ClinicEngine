namespace ClinicEngine.API.Modules.Clinics.DTOs;

public class ClinicResponse
{
    public Guid Id {get; set;} 
    public string Name {get; set;} = string.Empty;
    public string PhoneNumber {get; set;} = string.Empty;
    public string Address {get; set;} = string.Empty;
    public string Slug { get; set; } = string.Empty;
    public string OpeningHours {get; set;} = string.Empty;
    public string AnimalsSeen {get; set;} = string.Empty;
}