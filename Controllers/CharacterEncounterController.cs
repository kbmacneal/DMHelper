using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DM_helper;
using DM_helper.Models;

namespace DM_helper.Controllers
{
    public class CharacterEncounterController : Controller
    {
        private readonly Context _context;

        public CharacterEncounterController(Context context)
        {
            _context = context;
        }

        // GET: CharacterEncounter
        public async Task<IActionResult> Index()
        {
            var context = _context.CharacterEncounter.Include(c => c.Character).Include(c => c.Encounter);
            return View(await context.ToListAsync());
        }

        // GET: CharacterEncounter/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var characterEncounter = await _context.CharacterEncounter
                .Include(c => c.Character)
                .Include(c => c.Encounter)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (characterEncounter == null)
            {
                return NotFound();
            }

            return View(characterEncounter);
        }

        // GET: CharacterEncounter/Create
        //public IActionResult Create()
        //{
        //    ViewData["ID"] = new SelectList(_context.Character, "ID", "Name");
        //    ViewData["ID"] = new SelectList(_context.Encounter, "ID", "Name");
        //    return View();
        //}

        public IActionResult Create(int EncounterID, int SessionID)
        {
            ViewData["CharacterID"] = new SelectList(_context.Character, "ID", "Name");
            ViewData["ID"] = new SelectList(_context.Encounter, "ID", "Name", EncounterID);
            ViewBag.SessionID = SessionID;
            return View();
        }

        // POST: CharacterEncounter/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("EncounterID,CharacterID")] CharacterEncounter characterEncounter, int SessionID)
        {
            if (ModelState.IsValid)
            {
                _context.Add(characterEncounter);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return RedirectToAction("Details", "Session", new { id = SessionID });
        }

        // GET: CharacterEncounter/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var characterEncounter = await _context.CharacterEncounter.FindAsync(id);
            if (characterEncounter == null)
            {
                return NotFound();
            }
            ViewData["ID"] = new SelectList(_context.Character, "ID", "ID", characterEncounter.ID);
            ViewData["ID"] = new SelectList(_context.Encounter, "ID", "ID", characterEncounter.ID);
            return View(characterEncounter);
        }

        // POST: CharacterEncounter/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,EncounterID,CharacterID")] CharacterEncounter characterEncounter)
        {
            if (id != characterEncounter.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(characterEncounter);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CharacterEncounterExists(characterEncounter.ID))
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
            ViewData["ID"] = new SelectList(_context.Character, "ID", "ID", characterEncounter.ID);
            ViewData["ID"] = new SelectList(_context.Encounter, "ID", "ID", characterEncounter.ID);
            return View(characterEncounter);
        }

        // GET: CharacterEncounter/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var characterEncounter = await _context.CharacterEncounter
                .Include(c => c.Character)
                .Include(c => c.Encounter)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (characterEncounter == null)
            {
                return NotFound();
            }

            return View(characterEncounter);
        }

        // POST: CharacterEncounter/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var characterEncounter = await _context.CharacterEncounter.FindAsync(id);
            _context.CharacterEncounter.Remove(characterEncounter);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CharacterEncounterExists(int id)
        {
            return _context.CharacterEncounter.Any(e => e.ID == id);
        }
    }
}