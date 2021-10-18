using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TermProject_S1.Models;

namespace TermProject_S1.Views
{
    public class CustomerGradesController : Controller
    {
        private readonly SwiftMaidsContext _context;

        public CustomerGradesController(SwiftMaidsContext context)
        {
            _context = context;
        }

        // GET: CustomerGrades
        public async Task<IActionResult> Index()
        {
            return View(await _context.CustomerGrades.ToListAsync());
        }

        // GET: CustomerGrades/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customerGrade = await _context.CustomerGrades
                .FirstOrDefaultAsync(m => m.CustomerGradeID == id);
            if (customerGrade == null)
            {
                return NotFound();
            }

            return View(customerGrade);
        }

        // GET: CustomerGrades/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CustomerGrades/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CustomerGradeID,CustomerSalesLevel")] CustomerGrade customerGrade)
        {
            if (ModelState.IsValid)
            {
                _context.Add(customerGrade);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(customerGrade);
        }

        // GET: CustomerGrades/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customerGrade = await _context.CustomerGrades.FindAsync(id);
            if (customerGrade == null)
            {
                return NotFound();
            }
            return View(customerGrade);
        }

        // POST: CustomerGrades/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CustomerGradeID,CustomerSalesLevel")] CustomerGrade customerGrade)
        {
            if (id != customerGrade.CustomerGradeID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(customerGrade);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CustomerGradeExists(customerGrade.CustomerGradeID))
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
            return View(customerGrade);
        }

        // GET: CustomerGrades/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customerGrade = await _context.CustomerGrades
                .FirstOrDefaultAsync(m => m.CustomerGradeID == id);
            if (customerGrade == null)
            {
                return NotFound();
            }

            return View(customerGrade);
        }

        // POST: CustomerGrades/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var customerGrade = await _context.CustomerGrades.FindAsync(id);
            _context.CustomerGrades.Remove(customerGrade);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CustomerGradeExists(int id)
        {
            return _context.CustomerGrades.Any(e => e.CustomerGradeID == id);
        }
    }
}
