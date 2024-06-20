using ClubDeportivoLeones.Models;
using Microsoft.EntityFrameworkCore;

namespace ClubDeportivoLeones.Context
{
    public class MyContext: DbContext
    {
        public MyContext(DbContextOptions options): base (options) { }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Pago> Pagos { get; set; }
        public DbSet<Personal> Personal { get; set; }
        public DbSet<Horario> Horarios { get; set; }

    }
}
