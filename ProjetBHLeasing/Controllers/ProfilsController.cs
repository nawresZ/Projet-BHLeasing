using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProjetBHLeasing.Data;
using ProjetBHLeasing.Models;

namespace ProjetBHLeasing.Controllers
{
    public class ProfilsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProfilsController(ApplicationDbContext context)
        {
            _context = context;
        }
        // GET: Profils
        public async Task<IActionResult> Index()
        {
            return _context.Profil != null ?
                        View(await _context.Profil.ToListAsync()) :
                        Problem("Entity set 'ApplicationDbContext.Profil'  is null.");
        }

        // GET: Profils/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Profil == null)
            {
                return NotFound();
            }

            var profil = await _context.Profil
                .FirstOrDefaultAsync(m => m.id_profil == id);
            if (profil == null)
            {
                return NotFound();
            }

            return View(profil);
        }

        // GET: Profils/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Profils/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id_profil,Designation,b_systeme,id_user_modif")] Profil profil)
        {
            if (ModelState.IsValid)
            {
                profil.date_user_creat = DateTime.Now;
                profil.date_user_modif = DateTime.Now;

                _context.Add(profil);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index", "Clients");

            }
            return View(profil);
        }

        // GET: Profils/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Profil == null)
            {
                return NotFound();
            }

            var profil = await _context.Profil.FindAsync(id);
            if (profil == null)
            {
                return NotFound();
            }
            return View(profil);
        }

        // POST: Profils/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id_profil,Designation,b_systeme,id_user_modif,date_user_creat,date_user_modif")] Profil profil)
        {
            if (id != profil.id_profil)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(profil);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProfilExists(profil.id_profil))
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
            return View(profil);
        }

        // GET: Profils/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Profil == null)
            {
                return NotFound();
            }

            var profil = await _context.Profil
                .FirstOrDefaultAsync(m => m.id_profil == id);
            if (profil == null)
            {
                return NotFound();
            }

            return View(profil);
        }

        // POST: Profils/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Profil == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Profil'  is null.");
            }
            var profil = await _context.Profil.FindAsync(id);
            if (profil != null)
            {
                _context.Profil.Remove(profil);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProfilExists(int id)
        {
            return (_context.Profil?.Any(e => e.id_profil == id)).GetValueOrDefault();
        }
    }
}