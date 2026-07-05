using ClinicEngine.API.Modules.Clinics.DTOs;
using ClinicEngine.API.Modules.Clinics.Services;
using Microsoft.AspNetCore.Mvc;

namespace ClinicEngine.API.Modules.Clinics.Controllers;

[ApiController]
[Route("api/clinics")]
public class ClinicsController : ControllerBase //ControllerBase for the http helper methods
{
    private readonly ClinicService _service;

    public ClinicsController(ClinicService service)
    {
        _service = service; 
    }


    [HttpPost]
    public async Task<IActionResult> Create([FromBody] CreateClinicRequest request)
    {
        var result = await _service.CreateAsync(request);

        return CreatedAtAction(nameof(Create), new {id = result.Id}, result ); //the Id is to build a url location
        //api/clinics/{id} mapped to result
        //Location: /api/clinics/a3f8c21d-4b5c-...
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById([FromRoute] Guid id)
    {
        var result = await _service.GetByIdAsync(id);

        if(result == null)
        {
            return NotFound(); //404 notfound
        }
        return Ok(result); //200 Ok
    }
    
}