using AlmacenAPI.Context;
using AlmacenAPI.Interfaces;
using AlmacenAPI.Repositories.Repository;
using rencart.Interfaces;
using System;

namespace rencart.Repositories.Generico
{
    public class UnityOfWork : IUnityOfWork, IDisposable
    {
        private readonly AlmacenContext _dbContext;
        public UnityOfWork(AlmacenContext dbContext)
        {
            _dbContext = dbContext;

            //Inicializamo los repositorios y le pasamos el context al contructor de los repositorios
            Productos = new ProductoRepository(_dbContext);

        }

        public IProductoRepository Productos { get; private set; }

        public int Complete()
        {
            return _dbContext.SaveChanges();
        }

        public void Dispose()
        {
            _dbContext.Dispose();
        }
    }
}
