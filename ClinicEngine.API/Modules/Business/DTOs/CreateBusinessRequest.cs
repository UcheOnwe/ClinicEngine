namespace ClinicEngine.Modules.Business.DTOs;

public class CreateBusinessRequest
{
    public Guid UserId {get; set; }
    public string business_type {get; set;} = string.Empty;
    public string name {get; set;} = string.Empty;
    public string slug {get; set;} = string.Empty;
    public string status {get; set;} = string.Empty;


}