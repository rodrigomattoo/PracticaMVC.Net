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

        public ActionResult Eliminar(int id) {
            iRepositorioProducto.Eliminar(id);
            return RedirectToAction("Index");
        }

        public IActionResult Agregar() {
            return View();
        }
    }
}
