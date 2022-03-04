using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FinalProject_201810088.Data;
using FinalProject_201810088.Models;
using Microsoft.AspNetCore.Authorization;

namespace FinalProject_201810088.Controllers
{
    [Authorize]
    public class WorksController : Controller
    {
        private readonly DataContext _context;

        public WorksController(DataContext context)
        {
            _context = context;
        }

        // GET: Works
        public async Task<IActionResult> Index()
        {
            var dataContext = _context.Works.Include(w => w.Drawer).Include(w => w.Manga);
            return View(await dataContext.ToListAsync());
        }

        // GET: Works/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var work = await _context.Works
                .Include(w => w.Drawer)
                .Include(w => w.Manga)
                .FirstOrDefaultAsync(m => m.WorkId == id);
            if (work == null)
            {
                return NotFound();
            }

            return View(work);
        }

        // GET: Works/Create
        public IActionResult Create()
        {
            ViewData["DrawerId"] = new SelectList(_context.Drawers, "DrawerId", "Name");
            ViewData["MangaId"] = new SelectList(_context.Mangas, "MangaId", "Name");
            return View();
        }

        // POST: Works/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("WorkId,MangaId,DrawerId,StartDate,EndDate,AirsAt,Status")] Work work)
        {
            if (ModelState.IsValid)
            {
                _context.Add(work);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["DrawerId"] = new SelectList(_context.Drawers, "DrawerId", "Name", work.DrawerId);
            ViewData["MangaId"] = new SelectList(_context.Mangas, "MangaId", "Name", work.MangaId);
            return View(work);
        }

        // GET: Works/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var work = await _context.Works.FindAsync(id);
            if (work == null)
            {
                return NotFound();
            }
            ViewData["DrawerId"] = new SelectList(_context.Drawers, "DrawerId", "Name", work.DrawerId);
            ViewData["MangaId"] = new SelectList(_context.Mangas, "MangaId", "Name", work.MangaId);
            return View(work);
        }

        // POST: Works/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("WorkId,MangaId,DrawerId,StartDate,EndDate,AirsAt,Status")] Work work)
        {
            if (id != work.WorkId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(work);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!WorkExists(work.WorkId))
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
            ViewData["DrawerId"] = new SelectList(_context.Drawers, "DrawerId", "Name", work.DrawerId);
            ViewData["MangaId"] = new SelectList(_context.Mangas, "MangaId", "Name", work.MangaId);
            return View(work);
        }

        // GET: Works/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var work = await _context.Works
                .Include(w => w.Drawer)
                .Include(w => w.Manga)
                .FirstOrDefaultAsync(m => m.WorkId == id);
            if (work == null)
            {
                return NotFound();
            }

            return View(work);
        }

        // POST: Works/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var work = await _context.Works.FindAsync(id);
            _context.Works.Remove(work);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool WorkExists(int id)
        {
            return _context.Works.Any(e => e.WorkId == id);
        }
    }
}
