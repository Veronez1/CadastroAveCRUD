using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CadastroAve.Models;

namespace CadastroAve.Controllers
{
    public class AvesController : Controller
    {
        private readonly Contexto _context;

        public AvesController(Contexto context)
        {
            _context = context;
        }

        // GET: Aves
        public async Task<IActionResult> Index()
        {
              return View(await _context.Ave.ToListAsync());
        }

        // GET: Aves/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Ave == null)
            {
                return NotFound();
            }

            var ave = await _context.Ave
                .FirstOrDefaultAsync(m => m.Id == id);
            if (ave == null)
            {
                return NotFound();
            }

            return View(ave);
        }

        // GET: Aves/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Aves/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,NomeComum,NomeCientifico,Reino,Filo,Classe,Ordem,Familia,Genero,Especie,DistribuicaoGeografica")] Ave ave)
        {
            if (ModelState.IsValid)
            {
                _context.Add(ave);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(ave);
        }

        // GET: Aves/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Ave == null)
            {
                return NotFound();
            }

            var ave = await _context.Ave.FindAsync(id);
            if (ave == null)
            {
                return NotFound();
            }
            return View(ave);
        }

        // POST: Aves/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,NomeComum,NomeCientifico,Reino,Filo,Classe,Ordem,Familia,Genero,Especie,DistribuicaoGeografica")] Ave ave)
        {
            if (id != ave.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(ave);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AveExists(ave.Id))
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
            return View(ave);
        }

        // GET: Aves/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Ave == null)
            {
                return NotFound();
            }

            var ave = await _context.Ave
                .FirstOrDefaultAsync(m => m.Id == id);
            if (ave == null)
            {
                return NotFound();
            }

            return View(ave);
        }

        // POST: Aves/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Ave == null)
            {
                return Problem("Entity set 'Contexto.Ave'  is null.");
            }
            var ave = await _context.Ave.FindAsync(id);
            if (ave != null)
            {
                _context.Ave.Remove(ave);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AveExists(int id)
        {
          return _context.Ave.Any(e => e.Id == id);
        }
    }
}
