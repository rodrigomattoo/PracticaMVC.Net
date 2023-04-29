using PracticaMVC.Net.Dominio.Entidades;

namespace PracticaMVC.Net.Dominio.Logica
{
    public interface IRepositorioProducto
    {
        void Agregar(Producto producto);
        void Eliminar(int id);
        List<Producto> ObtenerProductos();
    }
}