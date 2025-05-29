using Microsoft.AspNetCore.Mvc;
using T2_QUIROZ_MIGUEL.Datos;
using T2_QUIROZ_MIGUEL.Models;

namespace T2_QUIROZ_MIGUEL.Controllers
{
    public class DistribuidorController : Controller
    {
        private readonly ApplicationDbContext _db;
        public DistribuidorController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Distribuidor> lista = _db.Distribuidor;
            return View(lista);
        }
    }
}
