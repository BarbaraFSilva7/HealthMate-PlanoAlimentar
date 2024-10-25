using HealthMate_PlanoAlimentar.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HealthMate_PlanoAlimentar.Controllers
{
    public class PlanoAlimentarController(AppDbContext context) : Controller
    {
        private readonly AppDbContext _context = context;

        public async Task<IActionResult> Index()
        {
            var dados = await _context.PlanoAlimentar.ToListAsync();

            return View(dados);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Dieta dieta)
        {
            if (ModelState.IsValid)
            {
                _context.PlanoAlimentar.Add(dieta);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(dieta);
        }

        
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
                return NotFound();

            var dados = await _context.PlanoAlimentar.FindAsync(id);

            if (dados == null)
                return NotFound();

            return View(dados); 
        }

        [HttpPost]
        public async Task<IActionResult> Edit (int id, Dieta dieta) 
        {
            if (id != dieta.Id)
                return NotFound();

            if (ModelState.IsValid)
            {
                _context.PlanoAlimentar.Update(dieta);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(); 
        }
          
    }
}


