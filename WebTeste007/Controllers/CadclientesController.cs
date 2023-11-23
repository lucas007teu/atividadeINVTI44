using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebTeste007.Data;
using WebTeste007.Models;

namespace WebTeste007.Controllers
{
    public class CadclientesController : Controller
    {
        private readonly DBContext _context;

        public CadclientesController(DBContext context)
        {
            _context = context;
        }

        // GET: Cadclientes
        public async Task<IActionResult> Index()
        {
              return _context.Cadclientes != null ? 
                          View(await _context.Cadclientes.ToListAsync()) :
                          Problem("Entity set 'DBContext.Cadclientes'  is null.");
        }

        // GET: Cadclientes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Cadclientes == null)
            {
                return NotFound();
            }

            var cadclientes = await _context.Cadclientes
                .FirstOrDefaultAsync(m => m.idClientes == id);
            if (cadclientes == null)
            {
                return NotFound();
            }

            return View(cadclientes);
        }

        // GET: Cadclientes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Cadclientes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("idClientes,Nome,Sobrenome,CPF")] Cadclientes cadclientes)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cadclientes);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(cadclientes);
        }

        // GET: Cadclientes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Cadclientes == null)
            {
                return NotFound();
            }

            var cadclientes = await _context.Cadclientes.FindAsync(id);
            if (cadclientes == null)
            {
                return NotFound();
            }
            return View(cadclientes);
        }

        // POST: Cadclientes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("idClientes,Nome,Sobrenome,CPF")] Cadclientes cadclientes)
        {
            if (id != cadclientes.idClientes)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cadclientes);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CadclientesExists(cadclientes.idClientes))
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
            return View(cadclientes);
        }

        // GET: Cadclientes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Cadclientes == null)
            {
                return NotFound();
            }

            var cadclientes = await _context.Cadclientes
                .FirstOrDefaultAsync(m => m.idClientes == id);
            if (cadclientes == null)
            {
                return NotFound();
            }

            return View(cadclientes);
        }

        // POST: Cadclientes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Cadclientes == null)
            {
                return Problem("Entity set 'DBContext.Cadclientes'  is null.");
            }
            var cadclientes = await _context.Cadclientes.FindAsync(id);
            if (cadclientes != null)
            {
                _context.Cadclientes.Remove(cadclientes);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CadclientesExists(int id)
        {
          return (_context.Cadclientes?.Any(e => e.idClientes == id)).GetValueOrDefault();
        }
    }
}
