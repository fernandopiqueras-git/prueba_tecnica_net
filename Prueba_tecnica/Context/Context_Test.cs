using Microsoft.EntityFrameworkCore;
using Prueba_tecnica.Clases;

namespace Prueba_tecnica.Context_Test

{
    public class Context_Test : DbContext
    {
        public Context_Test(DbContextOptions<Context_Test> options) : base(options) { }

        public DbSet<Data_Test> Data { get; set; }  // Tabla para los datos de mercado
    }
}

