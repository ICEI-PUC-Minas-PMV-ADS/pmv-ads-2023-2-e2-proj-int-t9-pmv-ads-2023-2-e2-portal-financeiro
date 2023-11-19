using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Portal_financeiro2023.Models;

namespace Portal_financeiro2023.Controllers
{
    public class DividasController : Controller
    {
        private readonly AppDbContext _context;

        public DividasController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Dividas
        public async Task<IActionResult> Index()
        {
            var appDbContext = _context.Dividas.Include(d => d.Despesa);
            return View(await appDbContext.ToListAsync());
        }

        // GET: Dividas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var divida = await _context.Dividas
                .Include(d => d.Despesa)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (divida == null)
            {
                return NotFound();
            }

            return View(divida);
        }

        // GET: Dividas/Create
        public IActionResult Create()
        {
            ViewData["DespesaId"] = new SelectList(_context.Despesas, "Id", "Conta");
            return View();
        }

        // POST: Dividas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Conta,Valor,Data,Pagamento,EmNegociação,DespesaId")] Divida divida)
        {
            if (ModelState.IsValid)
            {
                _context.Add(divida);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["DespesaId"] = new SelectList(_context.Despesas, "Id", "Conta", divida.DespesaId);
            return View(divida);
        }

        // GET: Dividas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var divida = await _context.Dividas.FindAsync(id);
            if (divida == null)
            {
                return NotFound();
            }
            ViewData["DespesaId"] = new SelectList(_context.Despesas, "Id", "Conta", divida.DespesaId);
            return View(divida);
        }

        // POST: Dividas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Conta,Valor,Data,Pagamento,EmNegociação,DespesaId")] Divida divida)
        {
            if (id != divida.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(divida);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DividaExists(divida.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["DespesaId"] = new SelectList(_context.Despesas, "Id", "Conta", divida.DespesaId);
            return View(divida);
        }

        // GET: Dividas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var divida = await _context.Dividas
                .Include(d => d.Despesa)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (divida == null)
            {
                return NotFound();
            }

            return View(divida);
        }

        // POST: Dividas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var divida = await _context.Dividas.FindAsync(id);
            if (divida != null)
            {
                _context.Dividas.Remove(divida);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DividaExists(int id)
        {
            return _context.Dividas.Any(e => e.Id == id);
        }
    }
}
