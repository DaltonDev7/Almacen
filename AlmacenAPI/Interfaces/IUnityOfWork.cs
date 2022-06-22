using AlmacenAPI.Interfaces;

namespace rencart.Interfaces
{
    public interface IUnityOfWork
    {

        IProductoRepository Productos { get; }

        int Complete();
        void Dispose();
    }
}
