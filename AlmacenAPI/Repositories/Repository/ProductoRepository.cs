using AlmacenAPI.Context;
using AlmacenAPI.Interfaces;
using AlmacenAPI.Models;
using rencart.Repositories.Generico;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace AlmacenAPI.Repositories.Repository
{
    public class ProductoRepository : BaseRepository<Producto>, IProductoRepository
    {
        public ProductoRepository(AlmacenContext context) : base(context)
        {
        }

        public void update(Producto producto)
        {
            var updateProducto = Get(producto.Id);
            updateProducto.Name = producto.Name;
            updateProducto.Precio =  producto.Precio;
            updateProducto.Cantidad = producto.Cantidad;
        }
    }
}
