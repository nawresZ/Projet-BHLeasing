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
    public class UtilisateursController : Controller
    {
        private readonly ApplicationDbContext _context;

        public UtilisateursController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Utilisateurs
        public async Task<IActionResult> Index()
        {
            var utilisateurs = _context.Utilisateur
                .Include(a => a.Profil)
                .ToList();
            return View(utilisateurs);

        }
        // GET: Utilisateurs/Login

        public IActionResult Login()
        {
            return View();
        }
        // POST: Utilisateurs/Login
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(Utilisateur user)
        {

            var existingUser = await _context.Utilisateur
         .Include(u => u.Profil) // Include the Profil navigation property
         .FirstOrDefaultAsync(u => u.login == user.login && u.password == user.password);


            if (existingUser != null)
            {
                // User is authenticated, perform login logic
                // TODO: Add your code here
                if (existingUser.Profil?.Designation == "centre appel")
                {
                    // Redirect to page1 for "centreappel" profile
                    TempData["Email"] = user.login; // Store email in TempData
                    return RedirectToAction("Create", "Clients");
                }
                else
                {
                    // Redirect to page2 for other profiles
                    TempData["Email"] = user.login; // Store email in TempData
                    return RedirectToAction("Index", "Clients");
                }




            }

            ModelState.AddModelError(string.Empty, "Invalid Login or password");


            return View(user);
        }

        // GET: Utilisateurs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Utilisateur == null)
            {
                return NotFound();
            }

            var utilisateur = await _context.Utilisateur
                .FirstOrDefaultAsync(m => m.id_user == id);
            if (utilisateur == null)
            {
                return NotFound();
            }

            return View(utilisateur);
        }

        // GET: Utilisateurs/Create
        public IActionResult Create()
        {
            var profiles = _context.Profil.ToList();
            ViewBag.ProfilItems = new SelectList(profiles, nameof(Profil.id_profil), nameof(Profil.Designation));


            return View();
        }

        // POST: Utilisateurs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id_user,nom,Prenom,login,password,abreviation,id_user_responsable,statut,b_modifier_ptf,mail,date_derniers_acces,id_user_modif,date_user_creat,date_user_modif,matricule,rib,id_departement")] Utilisateur utilisateur, int id_profil)
        {





            var selectedProfile = _context.Profil.FirstOrDefault(p => p.id_profil == id_profil);



            utilisateur.Profil = selectedProfile;

            utilisateur.date_user_creat = DateTime.Now;
            utilisateur.date_derniers_acces = DateTime.Now;
            utilisateur.date_user_modif = DateTime.Now;
            _context.Add(utilisateur);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index", "Clients");

        }

        // GET: Utilisateurs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Utilisateur == null)
            {
                return NotFound();
            }

            var utilisateur = await _context.Utilisateur.FindAsync(id);
            if (utilisateur == null)
            {
                return NotFound();
            }
            return View(utilisateur);
        }

        // POST: Utilisateurs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id_user,nom,Prenom,login,password,abreviation,id_user_responsable,statut,b_modifier_ptf,mail,date_derniers_acces,id_user_modif,date_user_creat,date_user_modif,matricule,rib,id_departement")] Utilisateur utilisateur)
        {
            if (id != utilisateur.id_user)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(utilisateur);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UtilisateurExists(utilisateur.id_user))
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
            return View(utilisateur);
        }

        // GET: Utilisateurs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Utilisateur == null)
            {
                return NotFound();
            }

            var utilisateur = await _context.Utilisateur
                .FirstOrDefaultAsync(m => m.id_user == id);
            if (utilisateur == null)
            {
                return NotFound();
            }

            return View(utilisateur);
        }

        // POST: Utilisateurs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Utilisateur == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Utilisateur'  is null.");
            }
            var utilisateur = await _context.Utilisateur.FindAsync(id);
            if (utilisateur != null)
            {
                _context.Utilisateur.Remove(utilisateur);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UtilisateurExists(int id)
        {
            return (_context.Utilisateur?.Any(e => e.id_user == id)).GetValueOrDefault();
        }
    }
}
