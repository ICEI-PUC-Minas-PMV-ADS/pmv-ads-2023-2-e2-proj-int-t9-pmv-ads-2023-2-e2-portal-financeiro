using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using PORTAL.Models;

namespace PORTAL.Controllers
{
    public class DespesasController : Controller
    {
        private readonly AppDbcontext _context;
        public DespesasController(AppDbcontext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var dados = await _context.Despesas.ToArrayAsync();

            return View(dados);
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Despesa despesa)
        {
            if (ModelState.IsValid)
            {

                _context.Despesas.Add(despesa);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(despesa);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
                return NotFound();
            var dados = await _context.Despesas.FindAsync(id);
            if (dados == null)
                return NotFound();

            return View(dados);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(int id, Despesa despesa)
        {
            if (id != despesa.Id)
                return NotFound();

            if (ModelState.IsValid)
            {
                _context.Despesas.Update(despesa);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View();
        }
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
                return NotFound();

            var dados = await _context.Despesas.FindAsync(id);

            if (dados == null)

                return NotFound();

            return View(dados);
        }

                public async Task<IActionResult> Delete(int? id)
                {
                    if (id == null)
                        return NotFound();

                    var dados = await _context.Despesas.FindAsync(id);

                    if (dados == null)

                        return NotFound();
                    return View(dados);

                }
                [HttpPost, ActionName("Delete")]
                

            public async Task<IActionResult> DeleteConfirmed(int? id)
            {
                if (id == null)
                    return NotFound();

                var dados = await _context.Despesas.FindAsync(id);

                if (dados == null)

                    return NotFound();

                _context.Despesas.Remove(dados);
                await _context.SaveChangesAsync();
                return RedirectToAction("index");
            }
        }
    }
        
    
