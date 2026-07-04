using ClinicEngine.API.Infrastructure.ClinicEngineDbContext;
using ClinicEngine.API.Modules.Clinics.Interfaces;
using Microsoft.EntityFrameworkCore;
using ClinicEngine.API.Modules.Clinics.Repositories;
using ClinicEngine.API.Modules.Clinics.Services;

//Section 1 Builder Services
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOpenApi(); //Register OpenAPI (Swagger Docs)




//Register DbContext — this tells .NET your 
//API has controller classes to route requests to
builder.Services.AddDbContext<ClinicEngineDbContext>(options =>
    //this is the Npgsql package we installed 
    //telling EF Core to use PostgreSQL specifically.
    options.UseNpgsql( 
        builder.Configuration.GetConnectionString("DefaultConnection")
        )
    .UseSnakeCaseNamingConvention() //Database snake_case naming conventions
);

// Register controllers — this tells .NET your 
// API has controller classes to route requests to
builder.Services.AddControllers();

// "When someone asks for IClinicRepository, give them ClinicRepository"
builder.Services.AddScoped<IClinicRepository, ClinicRepository>();

// Service registered directly — no interface yet
builder.Services.AddScoped<ClinicService>();




var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

//Tell the app to route request to controllers
app.MapControllers();


app.Run();

