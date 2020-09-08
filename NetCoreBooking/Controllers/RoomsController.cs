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
    public class RoomsController : Controller
    {
        private readonly AxContext _context;

        public RoomsController(AxContext context)
        {
            _context = context;
        }
        public int pageSize = 6;
        // GET: Rooms
        public async Task<IActionResult> Index(string seacrhString, int? page)
        {
            var bks = from m in _context.Room select m;
            if (!String.IsNullOrEmpty(seacrhString))
            {
                ViewBag.seacrhString = seacrhString;

                bks = bks.Where(s => s.room_name.Contains(seacrhString));
            }
            if (page > 0)
            {
                page = page;
            }
            else
            {
                page = 1;
            }

            int start = (int)(page - 1) * pageSize;

            ViewBag.pageCurrent = page;
            int totalPage = bks.Count();
            float totalNumsize = (totalPage / (float)pageSize);
            int numSize = (int)Math.Ceiling(totalNumsize);
            ViewBag.numSize = numSize;           
            ViewBag.posts = bks.OrderByDescending(x => x.room_id).Skip(start).Take(pageSize);
            //var axContext = _context.Booking.Include(b => b.Room).OrderByDescending(m => m.booking_id);
            //return View(await axContext.ToListAsync());
            return View(await bks.ToListAsync());
            //return View(axContext.ToPagedList(page ?? 1, 5));


        }

        // GET: Rooms/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var room = await _context.Room
                .FirstOrDefaultAsync(m => m.room_id == id);
            if (room == null)
            {
                return NotFound();
            }

            return View(room);
        }

        // GET: Rooms/Create
        public IActionResult Create()
        {

            return View();
        }

        // POST: Rooms/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("room_id,room_name,capacity")] Room room)
        {
            if (ModelState.IsValid)
            {
                _context.Add(room);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(room);
        }

        // GET: Rooms/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var room = await _context.Room.FindAsync(id);
            if (room == null)
            {
                return NotFound();
            }
            return View(room);
        }

        // POST: Rooms/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("room_id,room_name,capacity")] Room room)
        {
            if (id != room.room_id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(room);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RoomExists(room.room_id))
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
            return View(room);
        }

        // GET: Rooms/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var room = await _context.Room
                .FirstOrDefaultAsync(m => m.room_id == id);
            if (room == null)
            {
                return NotFound();
            }

            return View(room);
        }

        // POST: Rooms/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var room = await _context.Room.FindAsync(id);
            _context.Room.Remove(room);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RoomExists(string id)
        {
            return _context.Room.Any(e => e.room_id == id);
        }
    }
}
