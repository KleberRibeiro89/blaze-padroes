using blaze.Service;
using Blaze.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BController : ControllerBase
{
    private readonly IApostaService _service;
    public BController(IApostaService service)
    {
        _service = service; 
    }

    [HttpGet]
    public async Task<IActionResult> Sincronizar()
    {
        
        await _service.SincronizarAsync();
        return Ok(true);
    }
}
