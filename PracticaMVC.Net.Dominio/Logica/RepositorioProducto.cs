using PracticaMVC.Net.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaMVC.Net.Dominio.Logica
{
    public class RepositorioProducto : IRepositorioProducto
    {
        private static List<Producto> _productos = new List<Producto>();

        public RepositorioProducto() {
            Inicializar();
        }

        public void Eliminar(int id)
        {
            var poder = _productos.FirstOrDefault(x => x.Id == id);
            if (poder != null)
            {
                _productos.Remove(poder);
            }
        }

        private Producto ObtenerProductoPorId(int id)
        {
            Producto producto = new Producto();
            foreach (Producto p in _productos)
            {
                p.Id = id;
                producto = p;
            }
            return producto;
        }

        public List<Producto> ObtenerProductos()
        {
            return _productos;
        }

        private void Inicializar()
        {
            _productos.Clear();
            _productos.Add(new Producto(1, "SmartTv", 250000.00));
            _productos.Add(new Producto(2, "SmartPhone", 250000.00));
            _productos.Add(new Producto(3, "Tablet", 250000.00));
            _productos.Add(new Producto(4, "Notebook", 250000.00));
        }

        public void Agregar(Producto producto)
        {
            producto.Id = this.generarId();
            _productos.Add(producto);
        }

        private int generarId()
        {
            return _productos.Count();
        }
    }
}
