using ClinicEngine.API.Modules.Clinics.DTOs;
using ClinicEngine.API.Modules.Clinics.Interfaces;
using ClinicEngine.API.Modules.Clinics.Models;

namespace ClinicEngine.API.Modules.Clinics.Services;

//Implementing IClinicRepository Contract
public class ClinicService
{
    private readonly IClinicRepository _repository;

    public ClinicService(IClinicRepository repository)
    {
        _repository = repository;
    }

    //Helper method for proper slug(url generation)
    //following rules declared in the method

    private string GenerateSlug(string name)
    {
        return name
            .ToLower() //step1: everything in lowercase
            .Replace(" ", "-")  //step2: replace spaces to hyphens
            .Replace("&", "") //step3: strip special chars
            .Replace("!", "") //step3: strip special chars
            .Replace("--", "-"); //step4: clean double hyphens
    }

    //Building the ClinicResponse Service Output: ClinicResponse
    //input: CreateClinicRequests
    public async Task<ClinicResponse> CreateAsync(CreateClinicRequest request)
    {
        //1. Building the clinic model object from request + Server values
        var clinic = new ClinicProfile
        {
            Id = Guid.NewGuid(), //Server generated
            BusinessId = Guid.NewGuid(),
            Name = request.Name, //From client
            PhoneNumber = request.PhoneNumber,
            Address = request.Address,
            Slug = GenerateSlug(request.Name),
            Status = "SET UP",
            OpeningHours = request.OpeningHours,
            AnimalsSeen = request.AnimalsSeen,
            CreatedAt = DateTime.UtcNow
        };

        //2. Save via repository
        var saved = await _repository.CreateAsync(clinic);

        //3. Map to response DTO - Only safe fields
        // ClinicResponse DTO maps from saved
        //reading from saved to include id and other server generated entities
        return new ClinicResponse
        {
            Id = saved.Id,
            Name = saved.Name,
            PhoneNumber = saved.PhoneNumber,
            Address = saved.Address,
            Slug = saved.Slug,
            OpeningHours = saved.OpeningHours,
            AnimalsSeen = saved.AnimalsSeen
        };
    }
}