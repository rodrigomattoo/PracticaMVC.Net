using PracticaMVC.Net.Dominio.Entidades;

namespace PracticaMVC.Net.Dominio.Logica
{
    public interface IRepositorioProducto
    {
        void Eliminar(int id);
        List<Producto> ObtenerProductos();
    }
}