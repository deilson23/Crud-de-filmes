using ApiCrudFilmes.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiCrudFilmes.Data
{
    public class Context: DbContext
    {
        public Context(DbContextOptions<Context> opt) : base(opt)
        {

        }
        public DbSet<Filme>Filmes { get; set; }
    }
}
