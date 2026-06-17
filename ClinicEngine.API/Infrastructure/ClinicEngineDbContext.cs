using Microsoft.EntityFrameworkCore;
using ClinicEngine.API.Modules.Clinics.Models;

namespace ClinicEngine.API.Infrastructure.ClinicEngineDbContext;


class ClinicEngineDbContext : DbContext
{
    public ClinicEngineDbContext(DbContextOptions<ClinicEngineDbContext> options) : base(options)
    {
        
    }

    public DbSet<ClinicProfile> ClinicProfiles {get; set;}
}