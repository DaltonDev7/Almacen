using AlmacenAPI.Models;
using rencart.Interfaces;

namespace AlmacenAPI.Interfaces
{
    public interface IProductoRepository : IBaseRepository<Producto>
    {
        void update(Producto producto);
    }
}
