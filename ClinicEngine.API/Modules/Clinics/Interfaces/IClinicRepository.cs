using ClinicEngine.API.Modules.Clinics.Models;

namespace ClinicEngine.API.Modules.Clinics.Interfaces;

public interface IClinicRepository
{
    //Any class that wants to be an IClinicRepository must have a method named CreatAsync.
    //That method must accept a ClinicProfile
    //That method must return Task<ClinicProfile>.
    // input type : CliniProfile
    //Output type : Task<ClinicProfile>
    //The purpose of not having code here is becuase thinking ahead in time, different repositories 
    //have different ways of saving data
    //Example switching between saving data in PostgreSQL, SQL Server, 
    // or even different repository: MongoClinicRepository
    Task<ClinicProfile> CreateAsync(ClinicProfile clinic);
}