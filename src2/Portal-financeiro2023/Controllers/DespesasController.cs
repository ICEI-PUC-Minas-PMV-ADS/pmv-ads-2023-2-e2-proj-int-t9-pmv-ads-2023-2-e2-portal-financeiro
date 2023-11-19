using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Portal_financeiro2023.Models;

namespace Portal_financeiro2023.Controllers
{
    public class DespesasController : Controller
    {
        private readonly AppDbContext _context;
        public DespesasController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var dados = await _context.Despesas.ToListAsync();

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

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Relatorio(int? id)
        {
            if (id == null)
                return NotFound();

            var despesa = await _context.Despesas.FindAsync(id);

            if (despesa == null)
                return NotFound();
            var dividas = await _context.Dividas
                .Where(c => c.DespesaId == id)
                .OrderByDescending(c => c.Data)
                .ToListAsync();

            decimal total = dividas.Sum(c => c.Valor);

            ViewBag.Despesa = despesa;
            ViewBag.Total = total;
            return View(dividas);

        }
    }
}
    




