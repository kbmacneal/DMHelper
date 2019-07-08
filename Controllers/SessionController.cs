using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DM_helper.Classes;
using DM_helper.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DM_helper.Controllers
{
    public class SessionController : Controller
    {
        public class NoCharRoller
        {
            public int SessionID { get; set; }
            public string Roll { get; set; }
        }

        private readonly Context _context;

        public SessionController (Context context)
        {
            _context = context;
        }

        // GET: Session
        public async Task<IActionResult> Index ()
        {
            return View (await _context.Session.ToListAsync ());
        }

        // GET: Session/Details/5
        public async Task<IActionResult> Details (int? id, List<int> Result)
        {
            if (id == null)
            {
                return NotFound ();
            }

            var session = await _context.Session
                .Include (e => e.Campaign)
                .Include (e => e.Encounters)
                .ThenInclude (e => e.CharacterEncounter)
                .ThenInclude (e => e.Character)
                .ThenInclude (e => e.Weapon)
                .Include (e => e.Encounters)
                .ThenInclude (e => e.CharacterEncounter)
                .ThenInclude (e => e.Character)
                .ThenInclude (e => e.Melee)
                .Include (e => e.Encounters)
                .ThenInclude (e => e.CharacterEncounter)
                .ThenInclude (e => e.Character)
                .ThenInclude (e => e.Armor)
                //.ThenInclude(e => e.Character)
                //.ThenInclude(e => e.Weapon)
                .FirstOrDefaultAsync (m => m.ID == id);

            if (session == null)
            {
                return NotFound ();
            }

            if (Result.Count == 0)
            {
                ViewBag.Result = 0;
                ViewBag.ResultDetail = "";
            }
            else
            {
                ViewBag.Result = Result.Sum ();
                ViewBag.ResultDetail = String.Join ("+", Result);
            }

            ViewBag.CampaignID = session.Campaign.ID;

            return View (session);
        }

        // GET: Session/Create
        public IActionResult Create ()
        {
            return View ();
        }

        // POST: Session/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create ([Bind ("ID,Name,Notes")] Session session)
        {
            if (ModelState.IsValid)
            {
                _context.Add (session);
                await _context.SaveChangesAsync ();
                return RedirectToAction (nameof (Index));
            }
            return View (session);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateBlankSession (int CampaignID)
        {
            Session session = new Session ()
            {
                Name = "New Session",
                Campaign = await _context.Campaigns.FirstOrDefaultAsync (e => e.ID == CampaignID)
            };

            await _context.Session.AddAsync (session);
            await _context.SaveChangesAsync ();
            return RedirectToAction ("Details", "Campaign", new { id = CampaignID });
        }

        // GET: Session/Edit/5
        public async Task<IActionResult> Edit (int? id)
        {
            if (id == null)
            {
                return NotFound ();
            }

            var session = await _context.Session.FindAsync (id);
            if (session == null)
            {
                return NotFound ();
            }
            return View (session);
        }

        // POST: Session/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit (int id, [Bind ("ID,Name,Notes")] Session session)
        {
            if (id != session.ID)
            {
                return NotFound ();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update (session);
                    await _context.SaveChangesAsync ();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SessionExists (session.ID))
                    {
                        return NotFound ();
                    }
                    else
                    {
                        throw;
                    }
                }

                return RedirectToAction ("Details", "Session", new { id = session.ID });
            }
            return View (session);
        }

        // GET: Session/Delete/5
        public async Task<IActionResult> Delete (int? id)
        {
            if (id == null)
            {
                return NotFound ();
            }

            var session = await _context.Session
                .FirstOrDefaultAsync (m => m.ID == id);
            if (session == null)
            {
                return NotFound ();
            }

            return View (session);
        }

        // POST: Session/Delete/5
        [HttpPost, ActionName ("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed (int id)
        {
            var session = await _context.Session.FindAsync (id);
            _context.Session.Remove (session);
            await _context.SaveChangesAsync ();

            return RedirectToAction ("Index", "Campaign");
        }

        public async Task<IActionResult> RollDice (int SessionID, int CharacterID, int WeaponID)
        {
            var Session = await _context.Session.FindAsync (SessionID);
            var Character = await _context.Character.FindAsync (CharacterID);
            var Weapon = await _context.Weapons.FindAsync (WeaponID);

            if (Weapon == null)
            {
                var Melee = await _context.Melee.FindAsync (Convert.ToInt64 (WeaponID));
                if (Melee == null)
                {
                    return RedirectToAction ("Details", new { id = SessionID, Result = new List<int> () });
                }
                else
                {
                    if (Melee.Attribute == null)
                    {
                        return RedirectToAction ("Details", new { id = SessionID, Result = new List<int> () });
                    }

                    int stat_bonus = StatMod.mod_from_stat_val ((int) Helpers.GetPropValue (Character, Melee.Attribute));
                    int atk_bonus = (int) Helpers.GetPropValue (Character, nameof (Character.AtkBonus));

                    var baseroll = Classes.RollDice.Roll (Melee.Damage);

                    List<int> passer = new List<int> ();

                    baseroll.ForEach (e => passer.Add (e));
                    passer.Add (stat_bonus);
                    passer.Add (atk_bonus);

                    return RedirectToAction ("Details", new { id = SessionID, Result = passer });
                }
            }
            else
            {
                if (Weapon.Attribute == null)
                {
                    return RedirectToAction ("Details", new { id = SessionID, Result = new List<int> () });
                }

                int stat_bonus = StatMod.mod_from_stat_val ((int) Helpers.GetPropValue (Character, Weapon.Attribute));
                int atk_bonus = (int) Helpers.GetPropValue (Character, nameof (Character.AtkBonus));

                var baseroll = Classes.RollDice.Roll (Weapon.Damage);

                List<int> passer = new List<int> ();

                baseroll.ForEach (e => passer.Add (e));
                passer.Add (stat_bonus);
                passer.Add (atk_bonus);

                return RedirectToAction ("Details", new { id = SessionID, Result = passer });
            }
        }

        public async Task<IActionResult> RollNoCharDice ([Bind ("SessionID,Roll")] NoCharRoller roller)
        {
            List<int> passer = new List<int> ();

            var Session = await _context.Session.FindAsync (roller.SessionID);

            if (roller.Roll == "" || roller.Roll == null)
            {
                return RedirectToAction ("Details", new { id = roller.SessionID, Result = new List<int> () });
            }

            var baseroll = Classes.RollDice.Roll (roller.Roll);

            baseroll.ForEach (e => passer.Add (e));

            return RedirectToAction ("Details", new { id = roller.SessionID, Result = passer });
        }

        public async Task<IActionResult> EditCharacter (int? id, int? SessionID)
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
            ViewBag.SessionID = SessionID;
            return View (character);
        }

        // POST: Character/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditCharacter (int id, [Bind ("ID,Name,Faction,Homeworld,CurrentHP,MaxHP,CurrentSystemStrain,MaxSystemStrain,PermanentStrain,CurrentXP,XPTilNextLevel,AC,AtkBonus,Strength,Dexterity,Constitution,Intelligence,Wisdom,Charisma,Credits,Goals,Notes")] Character character, [Bind ("SessionID")] int? SessionID)
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
                return RedirectToAction ("Details", new { id = SessionID });
            }
            return View (character);
        }

        private bool SessionExists (int id)
        {
            return _context.Session.Any (e => e.ID == id);
        }

        private bool CharacterExists (int id)
        {
            return _context.Character.Any (e => e.ID == id);
        }
    }
}