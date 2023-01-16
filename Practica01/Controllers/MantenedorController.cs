using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Practica01.Models;

namespace Practica01.Controllers
{
    public class MantenedorController : Controller
    {
        private readonly ExampleSystembdContext _context;

        public MantenedorController(ExampleSystembdContext context)
        {
            _context = context; 
        }
        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> TablaUsuario()
        {
            return View(await _context.Usuarios.ToListAsync());
        }

        public IActionResult AdministradorUsuario()
        {
            ViewBag.nombres = new SelectList(_context.Usuarios, "Id", "Nombre");
            return View();
        }
        public IActionResult CrearUsuario()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nombre,Apellido,Email,Estado")] Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                _context.Add(usuario);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(usuario);
        }
    }
}
