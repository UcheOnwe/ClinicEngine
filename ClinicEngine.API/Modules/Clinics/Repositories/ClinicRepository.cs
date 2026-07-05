using ClinicEngine.API.Infrastructure.ClinicEngineDbContext;
using ClinicEngine.API.Modules.Clinics.Interfaces;
using ClinicEngine.API.Modules.Clinics.Models;


namespace ClinicEngine.API.Modules.Clinics.Repositories;

//Implements the IclinicRepository contract, This class provides the actual database implementation
//The constructor input: ClinicEngineDbContext
//output: ClinicRepository

public class ClinicRepository : IClinicRepository
{
    private  readonly ClinicEngineDbContext _context;

    public ClinicRepository (ClinicEngineDbContext context)
    {
        _context = context;
    }


    //Expanding on the CreateAsync method declared in IclinicRepository
    public async Task<ClinicProfile> CreateAsync(ClinicProfile clinic)
    {
        //Tell Entity framework to start tracking this clinic 
        //as a new record that should be inserted later.
        await _context.ClinicProfiles.AddAsync(clinic);
        //Save what was tracked to the database
        await _context.SaveChangesAsync();
        return clinic;
    }

    public async Task<ClinicProfile?> GetByIdAsync(Guid id)
    {
        return await _context.ClinicProfiles.FindAsync(id);
    }
}