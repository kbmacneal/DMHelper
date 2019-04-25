using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DM_helper;
using DM_helper.Archetypes;
using DM_helper.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace DM_helper.Controllers
{
    public class CharacterController : Controller
    {
        private readonly Context _context;

        public CharacterController (Context context)
        {
            _context = context;
        }

        // GET: Character
        public async Task<IActionResult> Index ()
        {
            var context = _context.Character;
            return View (await context.ToListAsync ());
        }

        // GET: Character/Details/5
        public async Task<IActionResult> Details (int? id)
        {
            if (id == null)
            {
                return NotFound ();
            }

            var character = await _context.Character
                .Include (c => c.Background)
                .Include (c => c.Gender)
                .FirstOrDefaultAsync (m => m.ID == id);
            if (character == null)
            {
                return NotFound ();
            }

            return View (character);
        }

        // GET: Character/Create
        public IActionResult Create ()
        {
            ViewData["BackgroundID"] = new SelectList (_context.Set<BackgroundArchetype> (), "ID", "Name");
            ViewData["GenderID"] = new SelectList (_context.Set<GenderArchetype> (), "ID", "Name");
            ViewData["ArmorID"] = new SelectList (_context.Set<ArmorArchetype> (), "ID", "Name");
            return View ();
        }

        // POST: Character/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create ([Bind ("ID,Name,BackgroundID,GenderID,Faction,Homeworld,CurrentHP,MaxHP,CurrentSystemStrain,MaxSystemStrain,PermanentStrain,CurrentXP,XPTilNextLevel,AC,AtkBonus,Strength,Dexterity,Constitution,Intelligence,Wisdom,Charisma,Credits,ArmorID,Goals,Notes")] Character character)
        {
            if (ModelState.IsValid)
            {
                Background bg = new Background (await _context.BackgroundArchetype.FirstOrDefaultAsync (e => e.ID == character.BackgroundID));

                bg.CharacterID=character.ID;

                Gender gen = new Gender (await _context.GenderArchetype.FirstOrDefaultAsync (e => e.ID == character.GenderID));

                gen.CharacterID=character.ID;

                Armor arm = new Armor (await _context.ArmorArchetype.FirstOrDefaultAsync (e => e.ID == character.ArmorID));

                arm.CharacterID=character.ID;

                character.Background = bg;
                character.Gender = gen;
                character.Armor = arm;

                _context.Add (character);
                _context.Add (bg);
                _context.Add (gen);
                _context.Add (arm);

                await _context.SaveChangesAsync ();
                return RedirectToAction (nameof (Index));
            }
            ViewData["BackgroundID"] = new SelectList (_context.Set<BackgroundArchetype> (), "ID", "Name", character.BackgroundID);
            ViewData["GenderID"] = new SelectList (_context.Set<GenderArchetype> (), "ID", "Name", character.GenderID);
            return View (character);
        }

        // GET: Character/Edit/5
        public async Task<IActionResult> Edit (int? id)
        {
            if (id == null)
            {
                return NotFound ();
            }

            var character = await _context.Character.FindAsync (id);
            if (character == null)
            {
                return NotFound ();
            }
            ViewData["BackgroundID"] = new SelectList (_context.Set<BackgroundArchetype> (), "ID", "Name", character.BackgroundID);
            ViewData["GenderID"] = new SelectList (_context.Set<GenderArchetype> (), "ID", "Name", character.GenderID);
            return View (character);
        }

        // POST: Character/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit (int id, [Bind ("ID,Name,BackgroundID,GenderID,Faction,Homeworld,CurrentHP,MaxHP,CurrentSystemStrain,MaxSystemStrain,PermanentStrain,CurrentXP,XPTilNextLevel,AC,AtkBonus,Strength,Dexterity,Constitution,Intelligence,Wisdom,Charisma,Credits,ArmorID,Goals,Notes")] Character character)
        {
            if (id != character.ID)
            {
                return NotFound ();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update (character);
                    await _context.SaveChangesAsync ();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CharacterExists (character.ID))
                    {
                        return NotFound ();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction (nameof (Index));
            }
            ViewData["BackgroundID"] = new SelectList (_context.Set<BackgroundArchetype> (), "ID", "Name", character.BackgroundID);
            ViewData["GenderID"] = new SelectList (_context.Set<GenderArchetype> (), "ID", "Name", character.GenderID);
            return View (character);
        }

        // GET: Character/Delete/5
        public async Task<IActionResult> Delete (int? id)
        {
            if (id == null)
            {
                return NotFound ();
            }

            var character = await _context.Character
                .Include (c => c.Background)
                .Include (c => c.Gender)
                .FirstOrDefaultAsync (m => m.ID == id);
            if (character == null)
            {
                return NotFound ();
            }

            return View (character);
        }

        // POST: Character/Delete/5
        [HttpPost, ActionName ("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed (int id)
        {
            var character = await _context.Character.FindAsync (id);
            _context.Character.Remove (character);
            await _context.SaveChangesAsync ();
            return RedirectToAction (nameof (Index));
        }

        private bool CharacterExists (int id)
        {
            return _context.Character.Any (e => e.ID == id);
        }
    }
}