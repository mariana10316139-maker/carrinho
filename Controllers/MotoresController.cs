using Microsoft.AspNetCore.Mvc;
using Dominio;
using DataAccess.Repositorios.Contratos;

[Route("api/[controller]")]
[ApiController]
public class MotoresController : ControllerBase
{
    private readonly IMotoresRepositorio _motoresRepositorio;

    public MotoresController(IMotoresRepositorio motoresRepositorio)
    {
        _motoresRepositorio = motoresRepositorio;
    }

    [HttpGet]
    public IActionResult ListarMotores()
    {
        var motores = _motoresRepositorio.ListarTodos();

        if (!motores.Any())
            return NoContent();

        return Ok(motores);
    }

    [HttpGet("{motoresID}")]
    public IActionResult Get(int motoresID)
    {
        var motores = _motoresRepositorio.ObterPorId(motoresID);

        if (motores == null)
            return NotFound();

        return Ok(motores);
    }

    [HttpPost]
    public IActionResult Post([FromBody] Motores motores)
    {
        _motoresRepositorio.AdicionarMotores(motores);
        return CreatedAtAction(nameof(Get), new { motoresID = motores.IdMotor }, motores);
    }
}