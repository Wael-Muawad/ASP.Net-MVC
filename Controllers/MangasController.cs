using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FinalProject_201810088.Data;
using FinalProject_201810088.Models;
using Microsoft.AspNetCore.Http;
using System.IO;
using Microsoft.AspNetCore.Authorization;

namespace FinalProject_201810088.Controllers
{
    [Authorize]
    public class MangasController : Controller
    {
        private readonly DataContext _context;

        public MangasController(DataContext context)
        {
            _context = context;
        }

        [Route("IndexCustomRoute")]
        // GET: Mangas
        public async Task<IActionResult> Index()
        {
            return View(await _context.Mangas.ToListAsync());
        }

        // GET: Mangas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var manga = await _context.Mangas
                .FirstOrDefaultAsync(m => m.MangaId == id);
            if (manga == null)
            {
                return NotFound();
            }

            return View(manga);
        }

        // GET: Mangas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Mangas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MangaId,Name,NoOfEpisodes,Description,CoverImage")] Manga manga, IFormFile CoverImage)
        {
            if (ModelState.IsValid)
            {
                if (CoverImage is not null)
                {
                    using (var stream = new MemoryStream())
                    {
                        await CoverImage.CopyToAsync(stream);
                        manga.CoverImage = stream.ToArray();
                    }
                }
                _context.Add(manga);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(manga);
        }

        // GET: Mangas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var manga = await _context.Mangas.FindAsync(id);
            if (manga == null)
            {
                return NotFound();
            }
            return View(manga);
        }

        // POST: Mangas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MangaId,Name,NoOfEpisodes,Description,CoverImage")] Manga manga, IFormFile CoverImage)
        {
            if (id != manga.MangaId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    if (CoverImage is not null)
                    {
                        using (var stream = new MemoryStream())
                        {
                            await CoverImage.CopyToAsync(stream);
                            manga.CoverImage = stream.ToArray();
                        }
                    }

                    _context.Update(manga);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MangaExists(manga.MangaId))
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
            return View(manga);
        }

        // GET: Mangas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var manga = await _context.Mangas
                .FirstOrDefaultAsync(m => m.MangaId == id);
            if (manga == null)
            {
                return NotFound();
            }

            return View(manga);
        }

        // POST: Mangas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var manga = await _context.Mangas.FindAsync(id);
            _context.Mangas.Remove(manga);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MangaExists(int id)
        {
            return _context.Mangas.Any(e => e.MangaId == id);
        }

        //CostPerManga
        public async Task<IActionResult> MangaCost()
        {
            var Mangas = await _context.Mangas.Include(m => m.Works).ThenInclude(w => w.Drawer).ToListAsync();

            return View(Mangas);
        }
    }
}
