using Microsoft.EntityFrameworkCore;

namespace Busco.Models
{
    public class BuscoContext : DbContext
    {
        public DbSet<Producto> Productos { get; set; }
        public DbSet<TipoProducto> TipoProductos { get; set; }

        public BuscoContext(DbContextOptions dco) : base(dco) {

        }

    }
}