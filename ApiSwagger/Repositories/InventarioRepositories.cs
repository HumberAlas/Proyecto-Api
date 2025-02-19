using ApiSwagger.Context;
using ApiSwagger.Model;
using Microsoft.EntityFrameworkCore;

namespace ApiSwagger.Repositories
{
    public class InventarioRepositories : IInventarioRepositories
    {
        private readonly InventarioContext _context;

        public InventarioRepositories(InventarioContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Inventario >> Get() => await _context.Inventarios.ToListAsync();

        public async Task<Inventario?> GetById(int id) => await _context.Inventarios.FindAsync(id);

        public async Task Add(Inventario producto) => await _context.Inventarios.AddAsync(producto);

        public void Update(Inventario entity)
        {
            _context.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
        }

        public void Delete(Inventario entity) => _context.Inventarios.Remove(entity);

        public async Task Save() => await _context.SaveChangesAsync();
    }
}
