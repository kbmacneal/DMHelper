using DM_helper.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace DM_helper.Controllers
{
    public class NotesController : Controller
    {
        private readonly Context _context;

        public NotesController(Context context)
        {
            _context = context;
        }

        // GET: Notes
        public async Task<IActionResult> Index()
        {
            return View(await _context.CampaignNotes.ToListAsync());
        }

        // GET: Notes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var campaignNote = await _context.CampaignNotes
                .FirstOrDefaultAsync(m => m.ID == id);
            if (campaignNote == null)
            {
                return NotFound();
            }

            return View(campaignNote);
        }

        // GET: Notes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Notes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,NoteText,Timestamp")] CampaignNote campaignNote)
        {
            if (ModelState.IsValid)
            {
                _context.Add(campaignNote);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(campaignNote);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateNewNote(int CampaignID)
        {
            CampaignNote note = new CampaignNote()
            {
                NoteText = "New Note",
                Timestamp = DateTime.Now,
                Campaign = await _context.Campaigns.FirstOrDefaultAsync(e => e.ID == CampaignID)
            };

            await _context.CampaignNotes.AddAsync(note);

            await _context.SaveChangesAsync();

            return RedirectToAction("Details", "Campaign", new { id = CampaignID });
        }

        // GET: Notes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var campaignNote = await _context.CampaignNotes.FindAsync(id);
            if (campaignNote == null)
            {
                return NotFound();
            }
            return View(campaignNote);
        }

        // POST: Notes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,NoteText,Timestamp")] CampaignNote campaignNote)
        {
            if (id != campaignNote.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(campaignNote);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CampaignNoteExists(campaignNote.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }

                var campaign = await _context.Campaigns.Include(e => e.Notes).FirstOrDefaultAsync(e => e.Notes.Select(f => f.ID).Contains(campaignNote.ID));

                return RedirectToAction("Details", "Campaign", new { id = campaign.ID });
            }
            return View(campaignNote);
        }

        // GET: Notes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var campaignNote = await _context.CampaignNotes
                .FirstOrDefaultAsync(m => m.ID == id);
            if (campaignNote == null)
            {
                return NotFound();
            }

            return View(campaignNote);
        }

        // POST: Notes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var campaignNote = await _context.CampaignNotes.FindAsync(id);
            _context.CampaignNotes.Remove(campaignNote);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CampaignNoteExists(int id)
        {
            return _context.CampaignNotes.Any(e => e.ID == id);
        }
    }
}