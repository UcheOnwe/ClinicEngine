using ClinicEngine.API.Infrastructure.ClinicEngineDbContext;
using Microsoft.EntityFrameworkCore;

//Section 1 Builder Services
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOpenApi(); //Register OpenAPI (Swagger Docs)

// Register controllers — this tells .NET your 
// API has controller classes to route requests to
builder.Services.AddControllers();

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

// Add services to the container.

builder.Services.AddOpenApi();

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

