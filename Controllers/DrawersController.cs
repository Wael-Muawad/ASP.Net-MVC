using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FinalProject_201810088.Data;
using FinalProject_201810088.Models;
using FinalProject_201810088.ViewModel;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System.IO;
using Microsoft.AspNetCore.Authorization;

namespace FinalProject_201810088.Controllers
{
    [Authorize]
    public class DrawersController : Controller
    {
        private readonly DataContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public DrawersController(DataContext context, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
        }

        //IndexFilter
        public async Task<IActionResult> IndexFilter(String SortBy)
        {
            var model = await _context.Drawers.Where(d => d.CostPerManga <= 40).ToListAsync();

            if (SortBy is not null)
            {
                switch (SortBy)
                {
                    case "Name":                       
                        return View(model.OrderBy(d => d.Name));
                    case "Name_des":
                        return View(model.OrderByDescending(d => d.Name));
                    case "EmailAddress":
                        return View(model.OrderBy(d => d.EmailAddress));
                    case "EmailAddress_des":
                        return View(model.OrderByDescending(d => d.EmailAddress));
                    case "PhoneNumber":
                        return View(model.OrderBy(d => d.PhoneNumber));
                    case "PhoneNumber_des":
                        return View(model.OrderByDescending(d => d.PhoneNumber));
                    case "CostPerManga":
                        return View(model.OrderBy(d => d.CostPerManga));
                    case "CostPerManga_des":
                        return View(model.OrderByDescending(d => d.CostPerManga));

                    default:
                        break;
                }
            }

            return View(model);
        }

        // GET: Drawers
        public async Task<IActionResult> Index(String SortBy)
        {
            var model = await _context.Drawers.ToListAsync();

            if (SortBy is not null)
            {
                switch (SortBy)
                {
                    case "Name":
                        return View(model.OrderBy(d => d.Name));
                    case "Name_des":
                        return View(model.OrderByDescending(d => d.Name));
                    case "EmailAddress":
                        return View(model.OrderBy(d => d.EmailAddress));
                    case "EmailAddress_des":
                        return View(model.OrderByDescending(d => d.EmailAddress));
                    case "PhoneNumber":
                        return View(model.OrderBy(d => d.PhoneNumber));
                    case "PhoneNumber_des":
                        return View(model.OrderByDescending(d => d.PhoneNumber));
                    case "CostPerManga":
                        return View(model.OrderBy(d => d.CostPerManga));
                    case "CostPerManga_des":
                        return View(model.OrderByDescending(d => d.CostPerManga));

                    default:
                        break;
                }
            }

            return View(model);
        }

        // GET: Drawers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var drawer = await _context.Drawers
                .FirstOrDefaultAsync(m => m.DrawerId == id);
            if (drawer == null)
            {
                return NotFound();
            }

            return View(drawer);
        }

        // GET: Drawers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Drawers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("DrawerId,Name,EmailAddress,PhoneNumber,CostPerManga")] Drawer drawer,IFormFile ProfilePicture)
        {
            if (ModelState.IsValid)
            {
                if (ProfilePicture is not null)
                {

                    string Filename = Guid.NewGuid().ToString() + Path.GetFileName(ProfilePicture.FileName);

                    String FullPath = $"{_webHostEnvironment.WebRootPath}\\Images\\{Filename}";
                    using (var stream = new FileStream(FullPath, FileMode.Create))
                    {
                        await ProfilePicture.CopyToAsync(stream);
                        drawer.ProfilePicture = $"/Images/{Filename}";
                    }

                }
                
                _context.Add(drawer);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(drawer);
        }

        // GET: Drawers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var drawer = await _context.Drawers.FindAsync(id);
            if (drawer == null)
            {
                return NotFound();
            }
            return View(drawer);
        }

        // POST: Drawers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("DrawerId,Name,EmailAddress,PhoneNumber,CostPerManga,ProfilePicture")] Drawer drawer, IFormFile ProfilePicture)
        {
            if (id != drawer.DrawerId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    if (ProfilePicture is not null)
                    {

                        string Filename = Guid.NewGuid().ToString() + Path.GetFileName(ProfilePicture.FileName);

                        String FullPath = $"{_webHostEnvironment.WebRootPath}\\Images\\{Filename}";
                        using (var stream = new FileStream(FullPath, FileMode.Create))
                        {
                            await ProfilePicture.CopyToAsync(stream);
                            drawer.ProfilePicture = $"/Images/{Filename}";
                        }

                    }

                    _context.Update(drawer);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DrawerExists(drawer.DrawerId))
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
            return View(drawer);
        }

        // GET: Drawers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var drawer = await _context.Drawers
                .FirstOrDefaultAsync(m => m.DrawerId == id);
            if (drawer == null)
            {
                return NotFound();
            }

            return View(drawer);
        }

        // POST: Drawers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var drawer = await _context.Drawers.FindAsync(id);
            _context.Drawers.Remove(drawer);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DrawerExists(int id)
        {
            return _context.Drawers.Any(e => e.DrawerId == id);
        }


        //FindStudent
        public IActionResult FindDrawer()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> FindDrawer(FindDrawerViewModel model)
        {
            model.Drawers = await _context.Drawers.ToListAsync();

            if (model.Name is not null)
            {
                model.Drawers = model.Drawers.Where(d => d.Name.ToLower().Contains(model.Name.ToLower()));
            }
            if (model.EmailAddress is not null)
            {
                model.Drawers = model.Drawers.Where(d => d.EmailAddress.ToLower().Contains(model.EmailAddress.ToLower()));
            }
            if (model.PhoneNumber is not null)
            {
                model.Drawers = model.Drawers.Where(d => d.PhoneNumber.ToLower().Contains(model.PhoneNumber.ToLower()));
            }
            if (model.CostPerManga is not null)
            {
                model.Drawers = model.Drawers.Where(d => d.CostPerManga == model.CostPerManga);
            }
            return View(model);
        }


        //CostPerDrawer
        public async Task<IActionResult> DrawerCost()
        {
            var Drawer = await _context.Drawers.Include(d => d.Works).ThenInclude(w => w.Manga).ToListAsync();

            return View(Drawer);
        }
    }
}
