namespace ClinicEngine.Modules.Staff.DTOs;

public class CreateStaffRequest
{
    public Guid ClinicId { get; set; } = Guid.Empty;
    public string Name { get; set; } = string.Empty;
    public string Role { get; set; } = string.Empty;
    public bool IsActive { get; set; } = false;

}