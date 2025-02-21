﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SteelHorseTrucks.Data;
using SteelHorseTrucks.Models;

namespace SteelHorseTrucks.Controllers
{
    public class TrucksController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TrucksController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Trucks
        public async Task<IActionResult> Index()
        {
            return View(await _context.Trucks.ToListAsync());
        }

        // GET: Trucks/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var trucks = await _context.Trucks
                .FirstOrDefaultAsync(m => m.ID == id);
            if (trucks == null)
            {
                return NotFound();
            }

            return View(trucks);
        }

        // GET: Trucks/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Trucks/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Model,Year,PayloadCapacity,Price,Warranty")] Trucks trucks)
        {
            if (ModelState.IsValid)
            {
                _context.Add(trucks);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(trucks);
        }

        // GET: Trucks/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var trucks = await _context.Trucks.FindAsync(id);
            if (trucks == null)
            {
                return NotFound();
            }
            return View(trucks);
        }

        // POST: Trucks/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Model,Year,PayloadCapacity,Price,Warranty")] Trucks trucks)
        {
            if (id != trucks.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(trucks);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TrucksExists(trucks.ID))
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
            return View(trucks);
        }

        // GET: Trucks/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var trucks = await _context.Trucks
                .FirstOrDefaultAsync(m => m.ID == id);
            if (trucks == null)
            {
                return NotFound();
            }

            return View(trucks);
        }

        // POST: Trucks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var trucks = await _context.Trucks.FindAsync(id);
            if (trucks != null)
            {
                _context.Trucks.Remove(trucks);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TrucksExists(int id)
        {
            return _context.Trucks.Any(e => e.ID == id);
        }
    }
}
