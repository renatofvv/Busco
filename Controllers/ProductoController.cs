using Microsoft.AspNetCore.Mvc;
using Busco.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Busco.Controllers
{
    public class ProductoController : Controller
    {
        private readonly BuscoContext _context;
        public ProductoController(BuscoContext context) 
        {
            _context = context;
        }
    

        public IActionResult Producto() 
        {
            ViewBag.Regiones = _context.Productos.ToList().Select(r => new SelectListItem(r.Nombre, r.Id.ToString()));
            return View();
        }

        [HttpPost]
        public IActionResult NuevoProducto(Producto p) 
        {
            if (ModelState.IsValid) 
            {
                _context.Add(p);
                _context.SaveChanges();
                return RedirectToAction("NuevoProductoConfirmacion");
            }
            return View(p);
        }

        public IActionResult EditarProductoConfirmacion() 
        {
            return View();
        }
    }
}