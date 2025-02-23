using Microsoft.EntityFrameworkCore;
using AgendaContactos.Models;

namespace AgendaContactos.Data
{
    public class AgendaContext : DbContext
    {
        public AgendaContext(DbContextOptions<AgendaContext> options) : base(options) { }

        public DbSet<Contacto> Contactos { get; set; }
    }
}
