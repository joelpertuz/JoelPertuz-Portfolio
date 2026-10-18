using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using JoelPertuzPortfolio.Data;
using System.Threading.Tasks;

namespace JoelPertuzPortfolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            // Consultar proyectos destacados y certificaciones desde SQL Server
            var projects = await _context.Projects.Where(p => p.IsFeatured).ToListAsync();
            var certifications = await _context.Certifications.ToListAsync();

            ViewBag.Certifications = certifications;
            return View(projects);
        }
    }
}