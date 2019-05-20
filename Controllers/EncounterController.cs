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
    public class EncounterController : Controller
    {
        private readonly Context _context;

        public EncounterController(Context context)
        {
            _context = context;
        }

        // GET: Encounter
        public async Task<IActionResult> Index()
        {
            var context = _context.Encounter.Include(e => e.Session);
            return View(await context.ToListAsync());
        }

        // GET: Encounter/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var encounter = await _context.Encounter
                .Include(e => e.Session)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (encounter == null)
            {
                return NotFound();
            }

            return View(encounter);
        }

        // GET: Encounter/Create
        public IActionResult Create()
        {
            ViewData["SessionID"] = new SelectList(_context.Set<Session>(), "ID", "Name");
            return View();
        }

        // POST: Encounter/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Name,Notes,SessionID")] Encounter encounter)
        {
            if (ModelState.IsValid)
            {
                _context.Add(encounter);
                await _context.SaveChangesAsync();
                return RedirectToAction("Details","Session",new{id = encounter.SessionID});
            }
            ViewData["SessionID"] = new SelectList(_context.Set<Session>(), "ID", "Name", encounter.SessionID);
            return View(encounter);
        }

        // GET: Encounter/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var encounter = await _context.Encounter.Include(e=>e.Session).FirstOrDefaultAsync(e=>e.ID == id);
            if (encounter == null)
            {
                return NotFound();
            }
            ViewData["SessionID"] = new SelectList(_context.Set<Session>(), "ID", "Name", encounter.SessionID);
            return View(encounter);
        }

        // POST: Encounter/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Name,Initiative,Notes,SessionID")] Encounter encounter)
        {
            if (id != encounter.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(encounter);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EncounterExists(encounter.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Details","Session",new{id = encounter.SessionID});
            }
            ViewData["SessionID"] = new SelectList(_context.Set<Session>(), "ID", "ID", encounter.SessionID);
            return View(encounter);
        }

        // GET: Encounter/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var encounter = await _context.Encounter
                .Include(e => e.Session)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (encounter == null)
            {
                return NotFound();
            }

            return View(encounter);
        }

        // POST: Encounter/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var encounter = await _context.Encounter.FindAsync(id);
            _context.Encounter.Remove(encounter);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EncounterExists(int id)
        {
            return _context.Encounter.Any(e => e.ID == id);
        }
    }
}