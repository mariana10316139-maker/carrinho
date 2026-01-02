using Microsoft.AspNetCore.Mvc;
using Dominio;
using DataAccess.Repositorios.Contratos;


[Route("api/[controller]")]
[ApiController]
public class PanhaController : ControllerBase
{
    private readonly IPanhaRepositorio _panhaRepositorio;

    public PanhaController(IPanhaRepositorio panhaRepositorio)
    {
        _panhaRepositorio = panhaRepositorio;
    }

    [HttpGet]
    public IActionResult ListarPanhas()
    {
        var panhas = _panhaRepositorio.ListarTodos();

        if (!panhas.Any())
            return NoContent();

        return Ok(panhas);
    }
}