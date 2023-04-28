using Microsoft.AspNetCore.Mvc;
using PracticaMVC.Net.Dominio.Entidades;
using PracticaMVC.Net.Dominio.Logica;

namespace PracticaMVC.Net.Web.Controllers
{
    public class ProductoController : Controller
    {
        private IRepositorioProducto iRepositorioProducto;
        public ProductoController(IRepositorioProducto repositorioProducto) { 
            this.iRepositorioProducto = repositorioProducto;
        }
        public IActionResult Index()
        {
            List<Producto> productos =  this.iRepositorioProducto.ObtenerProductos();
            return View(productos);
        }
    }
}
