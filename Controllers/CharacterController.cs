using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DM_helper.InterOp;
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
            return View (await _context.Character.ToListAsync ());
        }

        // GET: Character/Details/5
        public async Task<IActionResult> Details (int? id)
        {
            if (id == null)
            {
                return NotFound ();
            }

            var character = await _context.Character.Include (e => e.Equipment).Include (e => e.Weapon).Include (e => e.Melee).Include (e => e.Armor).ThenInclude(e=>e.Archetype)
                .FirstOrDefaultAsync (m => m.ID == id);
            if (character == null)
            {
                return NotFound ();
            }

            var characterInterop = new CharacterInterOp (character, _context);

            var archarmor = _context.ArmorArchetype;

            //apply the personalized armor override
            foreach(var armor in character.Armor)
            {
                await archarmor.Where(e=>e.ID == armor.Archetype.ID).ForEachAsync(e=>e.Name = armor.Name);
            }

            var selected = character.Armor.Select(e=>e.Archetype.ID);

            var armors = new MultiSelectList (_context.ArmorArchetype, "ID", "Name", selected);

            ViewBag.Armors = armors;
            return View (characterInterop);
        }

        public async Task<IActionResult> BindArmor ([Bind ("ID,SelectedArmor")] CharacterInterOp character)
        {

            var charac = _context.Character.FirstOrDefault (e => e.ID == character.ID);

            charac.Armor = new List<Armor> ();

            if (charac == null) return NotFound ();

            if (character.SelectedArmor != null)
            {
                foreach (var item in character.SelectedArmor)
                {
                    var armor = await _context.ArmorArchetype.FirstOrDefaultAsync (e => e.ID == item);

                    var adder = new Armor (armor);

                    charac.Armor.Add (adder);
                }
            }

            // _context.Armor.RemoveRange(_context.Armor.Where(e=>e.Character == null));

            await _context.SaveChangesAsync ();

            return RedirectToAction ("Details", new { ID = charac.ID });
        }

        // GET: Character/Create
        public IActionResult Create ()
        {
            var bgs = new SelectList (_context.BackgroundArchetype, "ID", "Name");

            var cls = new SelectList (_context.CharacterClassArchetype, "ID", "Name");

            var genders = new SelectList (_context.GenderArchetype, "ID", "Name");

            var armor = new SelectList (_context.ArmorArchetype, "ID", "Name");

            ViewBag.Backgrounds = bgs;
            ViewBag.Class = cls;
            ViewBag.Genders = genders;

            return View ();
        }

        // POST: Character/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create ([Bind ("ID,Name,Faction,Homeworld,CurrentHP,MaxHP,CurrentSystemStrain,MaxSystemStrain,PermanentStrain,CurrentXP,XPTilNextLevel,AC,AtkBonus,Strength,Dexterity,Constitution,Intelligence,Wisdom,Charisma,Credits,Goals,Notes,BackgroundID,ClassID,GenderID")] CharacterInterOp character)
        {
            if (ModelState.IsValid)
            {
                var charac = new Character (character);

                var background = new Background (_context.BackgroundArchetype.FirstOrDefault (e => e.ID == character.BackgroundID));

                var cls = new CharacterClass (_context.CharacterClassArchetype.FirstOrDefault (e => e.ID == character.ClassID));

                var gender = new Gender (_context.GenderArchetype.FirstOrDefault (e => e.ID == character.GenderID));

                _context.Attach (charac);

                charac.Gender = gender;
                charac.Class = cls;
                charac.Background = background;

                _context.Add (charac);

                await _context.SaveChangesAsync ();

                //var book = new Book { Title = "As You Like It" };
                //var author = new Author { AuthorId = 1 };
                //db.Attach(author);
                //author.Books.Add(book);
                //db.SaveChanges();

                return RedirectToAction (nameof (Index));
            }
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
            return View (character);
        }

        // POST: Character/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit (int id, [Bind ("ID,Name,Faction,Homeworld,CurrentHP,MaxHP,CurrentSystemStrain,MaxSystemStrain,PermanentStrain,CurrentXP,XPTilNextLevel,AC,AtkBonus,Strength,Dexterity,Constitution,Intelligence,Wisdom,Charisma,Credits,Goals,Notes")] Character character)
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
            var character = await _context.Character.Include(e=>e.Armor).FirstOrDefaultAsync(e=>e.ID ==id);
            // _context.Armor.RemoveRange(_context.Armor.Include(e=>e.Character).Where(e=>e.Character==character).ToArray());
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