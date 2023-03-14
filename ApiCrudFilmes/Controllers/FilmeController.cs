using ApiCrudFilmes.Data;
using Microsoft.AspNetCore.Mvc;

namespace ApiCrudFilmes.Controllers
{
    public class FilmeController : ControllerBase
    {
        private readonly Context _context;
        public FilmeController(Context context)
        {
            _context = context;

        }
    }
}
