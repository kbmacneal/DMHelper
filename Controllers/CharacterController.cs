using DM_helper.InterOp;
using DM_helper.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DM_helper.Controllers
{
    public class CharacterController : Controller
    {
        private readonly Context _context;

        public CharacterController(Context context)
        {
            _context = context;
        }

        // GET: Character
        public async Task<IActionResult> Index()
        {
            return View(await _context.Character.ToListAsync());
        }

        // GET: Character/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var character = await _context.Character.Include(e => e.Equipment).ThenInclude(e => e.Archetype).Include(e => e.Weapon).ThenInclude(e => e.Archetype).Include(e => e.Melee).ThenInclude(e => e.Archetype).Include(e => e.Armor).ThenInclude(e => e.Archetype).Include(e => e.Skills).Include(e => e.Foci).Include(e => e.PsionicAbilities)
                .FirstOrDefaultAsync(m => m.ID == id);

            if (character == null)
            {
                return NotFound();
            }

            var characterInterop = new CharacterInterOp(character, _context);

            //armor
            var archarmor = _context.ArmorArchetype;

            //apply the personalized armor override
            foreach (var armor in character.Armor)
            {
                await archarmor.Where(e => e.ID == armor.Archetype.ID).ForEachAsync(e => e.Name = armor.Name);
            }

            var selected = character.Armor.Select(e => e.Archetype.ID);

            var armors = new MultiSelectList(_context.ArmorArchetype, "ID", "Name", selected);

            ViewBag.Armors = armors;

            //equipment
            var archeq = _context.EquipmentArchetype;

            //apply the personalized armor override
            foreach (var eq in character.Equipment)
            {
                await archeq.Where(e => e.ID == eq.Archetype.ID).ForEachAsync(e => e.Name = eq.Name);
            }

            var selectedeq = character.Equipment.Select(e => e.Archetype.ID);

            var pressy = new List<PresentationEquipment>();

            await _context.EquipmentArchetype.ForEachAsync(e => pressy.Add(new PresentationEquipment(e)));

            var eqs = new MultiSelectList(pressy, "ID", "DropDownString", selectedeq);

            ViewBag.Equipment = eqs;

            //ranged
            var archranged = _context.WeaponArchetype;

            //apply the personalized armor override
            foreach (var ranged in character.Weapon)
            {
                await archranged.Where(e => e.ID == ranged.Archetype.ID).ForEachAsync(e => e.Name = ranged.Name);
            }

            var selectedweap = character.Weapon.Select(e => e.Archetype.ID);

            var weapons = new MultiSelectList(_context.WeaponArchetype, "ID", "Name", selectedweap);

            ViewBag.Weapons = weapons;
            //melee
            var archmelee = _context.MeleeArchetype;

            //apply the personalized armor override
            foreach (var melee in character.Melee)
            {
                await archmelee.Where(e => e.ID == melee.Archetype.ID).ForEachAsync(e => e.Name = melee.Name);
            }

            var selectedmelee = character.Melee.Select(e => e.Archetype.ID);

            var melees = new MultiSelectList(_context.MeleeArchetype, "ID", "Name", selectedmelee);

            ViewBag.Melee = melees;

            return View(characterInterop);
        }

        public async Task<IActionResult> BindArmor([Bind("ID,SelectedArmor")] CharacterInterOp character)
        {
            var charac = _context.Character.Include(e => e.Armor).ThenInclude(e => e.Archetype).FirstOrDefault(e => e.ID == character.ID);

            if (charac == null) return NotFound();

            if (character.SelectedArmor != null)
            {
                foreach (var item in character.SelectedArmor)
                {
                    //apply all the new armor
                    if (!charac.Armor.Select(e => e.Archetype.ID).Contains(item))
                    {
                        charac.Armor.Add(new Armor(await _context.ArmorArchetype.FirstOrDefaultAsync(e => e.ID == item)));
                    }
                }

                //remove all the unselected armor
                charac.Armor.Where(e => !character.SelectedArmor.Contains(Convert.ToInt32(e.Archetype.ID))).ToList().ForEach(e => charac.Armor.Remove(e));
            }

            await _context.SaveChangesAsync();

            await _context.Armor.Include(e => e.Character).Where(e => e.Character == null).ForEachAsync(e => _context.Armor.Remove(e));

            await _context.SaveChangesAsync();

            return RedirectToAction("Details", new { ID = charac.ID });
        }

        public async Task<IActionResult> BindEquipment([Bind("ID,SelectedEquipment")] CharacterInterOp character)
        {
            var charac = _context.Character.Include(e => e.Equipment).ThenInclude(e => e.Archetype).FirstOrDefault(e => e.ID == character.ID);

            if (character.SelectedEquipment != null)
            {
                foreach (var item in character.SelectedEquipment)
                {
                    //apply all the new armor
                    if (!charac.Equipment.Select(e => e.Archetype.ID).Contains(item))
                    {
                        charac.Equipment.Add(new Equipment(await _context.EquipmentArchetype.FirstOrDefaultAsync(e => e.ID == item)));
                    }
                }

                //remove all the unselected armor
                charac.Equipment.Where(e => !character.SelectedEquipment.Contains(Convert.ToInt32(e.Archetype.ID))).ToList().ForEach(e => charac.Equipment.Remove(e));
            }

            await _context.SaveChangesAsync();

            await _context.Equipment.Include(e => e.Character).Where(e => e.Character == null).ForEachAsync(e => _context.Equipment.Remove(e));

            await _context.SaveChangesAsync();

            return RedirectToAction("Details", new { ID = charac.ID });
        }

        public async Task<IActionResult> BindSkills([Bind("ID,Skills,Name")] CharacterInterOp character)
        {
            var charac = _context.Character.Include(e => e.Skills).ThenInclude(e => e.Archetype).FirstOrDefault(e => e.ID == character.ID);

            foreach (var item in character.Skills)
            {
                charac.Skills.FirstOrDefault(e => e.ID == item.ID).Level = item.Level;
            }

            await _context.SaveChangesAsync();

            return RedirectToAction("Details", new { ID = charac.ID });
        }

        public async Task<IActionResult> BindFoci([Bind("ID,Foci,Name")] CharacterInterOp character)
        {
            var charac = _context.Character.Include(e => e.Foci).ThenInclude(e => e.Archetype).FirstOrDefault(e => e.ID == character.ID);

            foreach (var item in character.Foci)
            {
                charac.Foci.FirstOrDefault(e => e.ID == item.ID).Level = item.Level;
            }

            await _context.SaveChangesAsync();

            return RedirectToAction("Details", new { ID = charac.ID });
        }

        public async Task<IActionResult> BindWeapon([Bind("ID,SelectedWeapon")] CharacterInterOp character)
        {
            var charac = _context.Character.Include(e => e.Weapon).ThenInclude(e => e.Archetype).FirstOrDefault(e => e.ID == character.ID);

            if (character.SelectedWeapon != null)
            {
                foreach (var item in character.SelectedWeapon)
                {
                    //apply all the new armor
                    if (!charac.Weapon.Select(e => e.Archetype.ID).Contains(item))
                    {
                        charac.Weapon.Add(new Weapon(await _context.WeaponArchetype.FirstOrDefaultAsync(e => e.ID == item)));
                    }
                }

                //remove all the unselected armor
                charac.Weapon.Where(e => !character.SelectedWeapon.Contains(Convert.ToInt32(e.Archetype.ID))).ToList().ForEach(e => charac.Weapon.Remove(e));
            }

            await _context.SaveChangesAsync();

            await _context.Weapons.Include(e => e.Character).Where(e => e.Character == null).ForEachAsync(e => _context.Weapons.Remove(e));

            await _context.SaveChangesAsync();

            return RedirectToAction("Details", new { ID = charac.ID });
        }

        public async Task<IActionResult> BindMelee([Bind("ID,SelectedMelee")] CharacterInterOp character)
        {
            var charac = _context.Character.Include(e => e.Melee).ThenInclude(e => e.Archetype).FirstOrDefault(e => e.ID == character.ID);

            if (character.SelectedMelee != null)
            {
                foreach (var item in character.SelectedMelee)
                {
                    //apply all the new armor
                    if (!charac.Melee.Select(e => e.Archetype.ID).Contains(item))
                    {
                        charac.Melee.Add(new Melee(await _context.MeleeArchetype.FirstOrDefaultAsync(e => e.ID == item)));
                    }
                }

                //remove all the unselected armor
                charac.Melee.Where(e => !character.SelectedMelee.Contains(Convert.ToInt32(e.Archetype.ID))).ToList().ForEach(e => charac.Melee.Remove(e));
            }

            await _context.SaveChangesAsync();

            await _context.Melee.Include(e => e.Character).Where(e => e.Character == null).ForEachAsync(e => _context.Melee.Remove(e));

            await _context.SaveChangesAsync();

            return RedirectToAction("Details", new { ID = charac.ID });
        }

        public async Task<IActionResult> BindPsionics([Bind("ID,PsionicAbilities")] CharacterInterOp character)
        {
            var charac = _context.Character.Include(e => e.PsionicAbilities).ThenInclude(e => e.Archetype).FirstOrDefault(e => e.ID == character.ID);

            foreach (var item in character.PsionicAbilities)
            {
                charac.PsionicAbilities.FirstOrDefault(e => e.ID == item.ID).is_active = item.is_active;
            }

            await _context.SaveChangesAsync();

            return RedirectToAction("Details", new { ID = charac.ID });
        }

        // GET: Character/Create
        public IActionResult Create()
        {
            var bgs = new SelectList(_context.BackgroundArchetype, "ID", "Name");

            var cls = new SelectList(_context.CharacterClassArchetype, "ID", "Name");

            var genders = new SelectList(_context.GenderArchetype, "ID", "Name");

            var armor = new SelectList(_context.ArmorArchetype, "ID", "Name");

            ViewBag.Backgrounds = bgs;
            ViewBag.Class = cls;
            ViewBag.Genders = genders;

            return View();
        }

        // POST: Character/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Name,Faction,Homeworld,CurrentHP,MaxHP,CurrentSystemStrain,MaxSystemStrain,PermanentStrain,CurrentXP,XPTilNextLevel,AC,AtkBonus,Strength,Dexterity,Constitution,Intelligence,Wisdom,Charisma,Credits,Goals,Notes,BackgroundID,ClassID,GenderID")] CharacterInterOp character)
        {
            if (ModelState.IsValid)
            {
                var charac = new Character(character);

                var background = new Background(_context.BackgroundArchetype.FirstOrDefault(e => e.ID == character.BackgroundID));

                var cls = new CharacterClass(_context.CharacterClassArchetype.FirstOrDefault(e => e.ID == character.ClassID));

                var gender = new Gender(_context.GenderArchetype.FirstOrDefault(e => e.ID == character.GenderID));

                _context.Attach(charac);

                charac.Gender = gender;
                charac.Class = cls;
                charac.Background = background;
                charac.Skills = new List<Skills>();
                (await _context.SkillsArchetype.ToListAsync()).ForEach(e => charac.Skills.Add(new Skills(e)));

                charac.Foci = new List<Foci>();
                (await _context.FociArchetype.ToListAsync()).ForEach(e => charac.Foci.Add(new Foci(e)));

                charac.PsionicAbilities = new List<PsionicAbility>();
                (await _context.PsionicSkillArchetypes.Include(e => e.PsionicSchool).ToListAsync()).ForEach(e => charac.PsionicAbilities.Add(new PsionicAbility(e)));

                _context.Add(charac);

                await _context.SaveChangesAsync();

                //var book = new Book { Title = "As You Like It" };
                //var author = new Author { AuthorId = 1 };
                //db.Attach(author);
                //author.Books.Add(book);
                //db.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            return View(character);
        }

        // GET: Character/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var character = await _context.Character.FindAsync(id);
            if (character == null)
            {
                return NotFound();
            }
            return View(character);
        }

        // POST: Character/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Name,Faction,Homeworld,CurrentHP,MaxHP,CurrentSystemStrain,MaxSystemStrain,PermanentStrain,CurrentXP,XPTilNextLevel,AC,AtkBonus,Strength,Dexterity,Constitution,Intelligence,Wisdom,Charisma,Credits,Goals,Notes")] Character character)
        {
            if (id != character.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(character);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CharacterExists(character.ID))
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
            return View(character);
        }

        // GET: Character/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var character = await _context.Character
                .FirstOrDefaultAsync(m => m.ID == id);
            if (character == null)
            {
                return NotFound();
            }

            return View(character);
        }

        // POST: Character/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var character = await _context.Character.Include(e => e.Equipment).Include(e => e.Weapon).Include(e => e.Melee).Include(e => e.Armor).Include(e => e.Skills).Include(e => e.Foci).Include(e => e.PsionicAbilities).FirstOrDefaultAsync(e => e.ID == id);
            // _context.Armor.RemoveRange(_context.Armor.Include(e=>e.Character).Where(e=>e.Character==character).ToArray());
            _context.Character.Remove(character);
            await _context.SaveChangesAsync();

            await _context.Skills.Include(e => e.Character).Where(e => e.Character == null).ForEachAsync(e => _context.Skills.Remove(e));
            await _context.Backgrounds.Include(e => e.Character).Where(e => e.Character == null).ForEachAsync(e => _context.Backgrounds.Remove(e));
            await _context.Genders.Include(e => e.Character).Where(e => e.Character == null).ForEachAsync(e => _context.Genders.Remove(e));
            await _context.Foci.Include(e => e.Character).Where(e => e.Character == null).ForEachAsync(e => _context.Foci.Remove(e));
            await _context.PsionicAbilities.Include(e => e.Character).Where(e => e.Character == null).ForEachAsync(e => _context.PsionicAbilities.Remove(e));

            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public async Task<IActionResult> CloneCharacter([Bind("ID")] Character c)
        {
            await Character.CloneCharacterAsync(c.ID, _context);

            return RedirectToAction("Index");
        }

        private bool CharacterExists(int id)
        {
            return _context.Character.Any(e => e.ID == id);
        }
    }
}