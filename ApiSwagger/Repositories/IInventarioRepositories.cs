using ApiSwagger.Model;

namespace ApiSwagger.Repositories
{
    public interface IInventarioRepositories
    {
        Task<IEnumerable<Inventario>> Get();
        Task<Inventario?> GetById(int id);
        Task Add(Inventario inventario);
        void Update(Inventario inventario);
        void Delete(Inventario entity);
        Task Save();
    }
}
