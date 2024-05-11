using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVC_SQLite_test2.Models;

namespace MVC_SQLite_test2.Controllers
{
    public class VærDataController : Controller
    {
        private readonly VærDataContext _context;

        public VærDataController(VærDataContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.VærData.ToListAsync());
        }

        // GET: VærData/Create
        // Denne er selve Create siden
        public IActionResult Create()
        {
            return View();
        }

        // POST: VærData/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        // Denne er det som lar bruker skrive inn ting i databasen
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Dato,Temperatur,Kommentar,Bruker")] VærData værData)
        {
            if (ModelState.IsValid)
            {
                _context.Add(værData);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index)); 
            }
            return View(værData);
        }
    }
}
