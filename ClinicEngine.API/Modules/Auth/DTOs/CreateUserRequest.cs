namespace ClinicEngine.Modules.Auth.DTOs;

public class CreateUserRequest
{
    public string Email { get; set; } = string.Empty;
    public string PasswordHash { get; set; } = string.Empty; //make sure to hash this before storing in the database


}