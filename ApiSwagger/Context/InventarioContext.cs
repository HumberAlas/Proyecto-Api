using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using ApiSwagger.Model;

namespace ApiSwagger.Context
{
    public class InventarioContext : DbContext
    {
        public InventarioContext(DbContextOptions<InventarioContext> options) : base(options) { }

        public DbSet<Inventario> Inventarios { get; set; }
    }
}
