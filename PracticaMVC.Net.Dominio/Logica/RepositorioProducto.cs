using PracticaMVC.Net.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaMVC.Net.Dominio.Logica
{
    internal class RepositorioProducto : IRepositorioProducto
    {
        private static List<Producto> _productos = new List<Producto>();

        public RepositorioProducto() {
            Inicializar();
        }

        public List<Producto> ObtenerProductos()
        {
            return _productos;
        }

        private void Inicializar()
        {
            _productos.Add(new Producto(1,"SmartTv",250000.00));
            _productos.Add(new Producto(1, "SmartPhone", 250000.00));
            _productos.Add(new Producto(1, "Tablet", 250000.00));
            _productos.Add(new Producto(1, "Notebook", 250000.00));
        }
    }
}
