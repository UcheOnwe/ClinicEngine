namespace ClinicEngine.Modules.Pet.DTOs;

public class CreatePetRequest
{
    public Guid ClinicId { get; set; } = Guid.Empty;
    public string Name { get; set; } = string.Empty;
    public string Species { get; set; } = string.Empty;
    public string Breed { get; set; } = string.Empty;
    public string Notes { get; set; } = string.Empty;
    public DateTime Dob { get; set; } = DateTime.UtcNow;



}