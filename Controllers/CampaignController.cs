using DM_helper.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace DM_helper.Controllers
{
    public class CampaignController : Controller
    {
        private readonly Context _context;

        public CampaignController(Context context)
        {
            _context = context;
        }

        // GET: Campaign
        public async Task<IActionResult> Index()
        {
            return View(await _context.Campaigns.ToListAsync());
        }

        // GET: Campaign/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var campaign = await _context.Campaigns.Include(e => e.Notes).Include(e => e.Sessions)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (campaign == null)
            {
                return NotFound();
            }

            return View(campaign);
        }

        // GET: Campaign/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Campaign/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Name")] Campaign campaign)
        {
            if (ModelState.IsValid)
            {
                _context.Add(campaign);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(campaign);
        }

        // GET: Campaign/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var campaign = await _context.Campaigns.FindAsync(id);
            if (campaign == null)
            {
                return NotFound();
            }
            return View(campaign);
        }

        // POST: Campaign/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Name")] Campaign campaign)
        {
            if (id != campaign.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(campaign);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CampaignExists(campaign.ID))
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
            return View(campaign);
        }

        // GET: Campaign/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var campaign = await _context.Campaigns.Include(e => e.Notes).Include(e => e.Sessions).FirstOrDefaultAsync(e => e.ID == id);

            if (campaign == null)
            {
                return NotFound();
            }

            return View(campaign);
        }

        // POST: Campaign/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var campaign = await _context.Campaigns.Include(e => e.Notes).Include(e => e.Sessions).FirstOrDefaultAsync(e => e.ID == id);

            campaign.Notes.ForEach(e => _context.CampaignNotes.Remove(e));

            await _context.Session.Include(e => e.Encounters).ThenInclude(e => e.CharacterEncounter).Where(e => e.ID == id).ForEachAsync(e =>
              {
                  e.Encounters.Select(f => f.CharacterEncounter).ToList().ForEach(f => f.ForEach(g => _context.CharacterEncounter.Remove(g)));
                  e.Encounters.ForEach(f => _context.Encounter.Remove(f));
                  _context.Session.Remove(e);
              });

            _context.Campaigns.Remove(campaign);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CampaignExists(int id)
        {
            return _context.Campaigns.Any(e => e.ID == id);
        }
    }
}