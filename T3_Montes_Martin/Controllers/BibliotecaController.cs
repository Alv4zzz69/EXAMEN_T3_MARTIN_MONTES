using Microsoft.AspNetCore.Mvc;

namespace T3_Montes_Martin.Controllers
{
    // Puedes agregar [Authorize] aquí si quieres proteger estas pestañas con Login de SQL
    public class BibliotecaController : Controller
    {
        // GET: /Biblioteca/Arquitectura
        public IActionResult Arquitectura()
        {
            return View();
        }

        // GET: /Biblioteca/Diseno
        public IActionResult Diseno()
        {
            return View();
        }
    }
}