using Microsoft.EntityFrameworkCore;

namespace Busco.Models
{
    public class BuscoContext : DbContext
    {
        public DbSet<Producto> Entrenadores { get; set; }
        public DbSet<TipoProducto> Pueblos { get; set; }
        
    }
}