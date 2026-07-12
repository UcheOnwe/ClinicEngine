using ClinicEngine.API.Infrastructure.ClinicEngineDbContext;
using ClinicEngine.API.Modules.Clinics.Interfaces;
using Microsoft.EntityFrameworkCore;
using ClinicEngine.API.Modules.Clinics.Repositories;
using ClinicEngine.API.Modules.Clinics.Services;
using FluentValidation.AspNetCore;
using FluentValidation;
using ClinicEngine.API.Modules.Clinics.Validators;

//Section 1 Builder Services
var builder = WebApplication.CreateBuilder(args);


/*  If I need a Service, it goes in builder.Service 
    If I need Middleware, it goes after builder.Build().
    If I need to expose endpoints, I call MapControllers().
    If I need the app to start, I call Run()

*/

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

builder.Services.AddFluentValidationAutoValidation();

builder.Services.AddValidatorsFromAssemblyContaining<CreateClinicRequestValidator>();

//Always before builder.Build();
//Builder for CORS - Cross-Origin Resource Sharing with React
//React will be running on a different port from our API so API blocks it for protection
//Thats when CORS comes in to tell our API its okay to allow to communicate with this Port
builder.Services.AddCors(options =>
{
   options.AddPolicy("AllowReactApp", policy =>
   {
       policy
        .WithOrigins("http://localhost:3000") //Only this Origin is allowed, everything else blocked
        .AllowAnyHeader() //Allows Content-Type, Authorization, and other headers react will send
        //with requests
        .AllowAnyMethod(); //Allows GET, POST, PUT, DELETE - All http verbs React might use
   }); 
});





var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

//Telling the api to allow CORS(Cross-Origin Resourse Sharing) with React
app.UseCors("AllowReactApp");

//Tell the app to route request to controllers
app.MapControllers();


app.Run();

