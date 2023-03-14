using ApiCrudFilmes.Data;
using ApiCrudFilmes.Models;
using Microsoft.AspNetCore.Mvc;

namespace ApiCrudFilmes.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FilmeController : ControllerBase
    {
        private readonly Context _context;
        public FilmeController(Context context)
        {
            _context = context;

        }
        [HttpGet]
        public IActionResult BuscaFilmes()
        {
            
            return Ok(_context.Filmes);
        }
        [HttpGet("{id}")]
        public IActionResult BuscarFilmePorId(int id)
        {
            Filme filme = _context.Filmes.FirstOrDefault(filme => filme.Id==id);
            if (filme != null)
            {
                return Ok(filme);
            }
            return NotFound();
        }
        [HttpPost]
        public IActionResult AddFilme([FromBody]Filme filme)
        {
            _context.Filmes.Add(filme);
            _context.SaveChanges();
            return CreatedAtAction(nameof(BuscarFilmePorId), new {Id = filme.Id}, filme);
        }
    }
}
