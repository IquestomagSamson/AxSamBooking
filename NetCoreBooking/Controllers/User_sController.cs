using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Booking_Room.Models;
using NetCoreBooking.Data;

namespace NetCoreBooking.Controllers
{
    public class User_sController : Controller
    {
        private readonly AxContext _context;

        public User_sController(AxContext context)
        {
            _context = context;
        }

        // GET: User_s
        public async Task<IActionResult> Index(string seacrhString)
        {
            var bks = from m in _context.User_s select m;

            if (!String.IsNullOrEmpty(seacrhString))
            {
                bks = bks.Where(s => s.User_name.Contains(seacrhString));
            }
            //var axContext = _context.Booking.Include(b => b.Room).OrderByDescending(m => m.booking_id);
            //return View(await axContext.ToListAsync());
            return View(await bks.ToListAsync());
            //return View(axContext.ToPagedList(page ?? 1, 5));


        }
        // GET: User_s/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user_s = await _context.User_s
                .FirstOrDefaultAsync(m => m.User_id == id);
            if (user_s == null)
            {
                return NotFound();
            }

            return View(user_s);
        }

        // GET: User_s/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: User_s/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("User_id,User_name")] User_s user_s)
        {
            if (ModelState.IsValid)
            {
                _context.Add(user_s);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(user_s);
        }

        // GET: User_s/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user_s = await _context.User_s.FindAsync(id);
            if (user_s == null)
            {
                return NotFound();
            }
            return View(user_s);
        }

        // POST: User_s/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("User_id,User_name")] User_s user_s)
        {
            if (id != user_s.User_id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(user_s);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!User_sExists(user_s.User_id))
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
            return View(user_s);
        }

        // GET: User_s/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user_s = await _context.User_s
                .FirstOrDefaultAsync(m => m.User_id == id);
            if (user_s == null)
            {
                return NotFound();
            }

            return View(user_s);
        }

        // POST: User_s/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var user_s = await _context.User_s.FindAsync(id);
            _context.User_s.Remove(user_s);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool User_sExists(string id)
        {
            return _context.User_s.Any(e => e.User_id == id);
        }
    }
}
