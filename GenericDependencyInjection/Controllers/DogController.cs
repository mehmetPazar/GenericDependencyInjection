using Microsoft.AspNetCore.Mvc;
using RestApi.Interfaces;

namespace RestApi.Controllers;

[ApiController]
[Route("[controller]")]
public class DogController : ControllerBase
{
    private readonly IDog _dog;
    public DogController(IDog dog)
    {
        _dog = dog;
    }

    [HttpGet]
    public IActionResult Bark()
    {
        string response = _dog.Bark();
        return Ok(response);
    }
}