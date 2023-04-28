using PracticaMVC.Net.Dominio.Entidades;

namespace PracticaMVC.Net.Dominio.Logica
{
    public interface IRepositorioProducto
    {
        List<Producto> ObtenerProductos();
    }
}