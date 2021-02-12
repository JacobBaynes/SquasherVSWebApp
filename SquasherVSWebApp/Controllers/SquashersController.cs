using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SquasherVSWebApp.Data;
using SquasherVSWebApp.Models;

namespace SquasherVSWebApp.Controllers
{
    public class SquashersController : Controller
    {
        private readonly SquasherContext _context;

        public SquashersController(SquasherContext context)
        {
            _context = context;
        }

        // GET: Squashers
        public async Task<IActionResult> Index()
        {
            return View(await _context.Squashers.ToListAsync());
        }

        // GET: Squashers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var squasher = await _context.Squashers
                .FirstOrDefaultAsync(m => m.ID == id);
            if (squasher == null)
            {
                return NotFound();
            }

            return View(squasher);
        }

        // GET: Squashers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Squashers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Name")] Squasher squasher)
        {
            if (ModelState.IsValid)
            {
                _context.Add(squasher);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(squasher);
        }

        // GET: Squashers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var squasher = await _context.Squashers.FindAsync(id);
            if (squasher == null)
            {
                return NotFound();
            }
            return View(squasher);
        }

        // POST: Squashers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Name")] Squasher squasher)
        {
            if (id != squasher.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(squasher);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SquasherExists(squasher.ID))
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
            return View(squasher);
        }

        // GET: Squashers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var squasher = await _context.Squashers
                .FirstOrDefaultAsync(m => m.ID == id);
            if (squasher == null)
            {
                return NotFound();
            }

            return View(squasher);
        }

        // POST: Squashers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var squasher = await _context.Squashers.FindAsync(id);
            _context.Squashers.Remove(squasher);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SquasherExists(int id)
        {
            return _context.Squashers.Any(e => e.ID == id);
        }
    }
}
