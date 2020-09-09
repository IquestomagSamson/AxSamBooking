using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Booking_Room.Models;
using PagedList;
using NetCoreBooking.Data;
using NetCoreBooking_PagedList;

namespace NetCoreBooking.Controllers
{
    public class BookingsController : Controller
    {
        private readonly AxContext _context;

        public BookingsController(AxContext context)
        {
            _context = context;
        }
        public AxContext db = new AxContext();
        public int pageSize = 6;
        // GET: Bookings

        //public async Task<IActionResult> Index(string seacrhString, int? page)
        //{
        //    var bks = from m in _context.Booking select m;

        //    if (!String.IsNullOrEmpty(seacrhString))
        //    {
        //        ViewBag.seacrhString = seacrhString;

        //        bks = bks.Where(s => s.booking_title.Contains(seacrhString));
        //    }
        //    if (page > 0)
        //    {
        //        page = page;
        //    }
        //    else
        //    {
        //        page = 1;
        //    }

        //    int start = (int)(page - 1) * pageSize;

        //    ViewBag.pageCurrent = page;
        //    int totalPage = bks.Count();
        //    float totalNumsize = (totalPage / (float)pageSize);
        //    int numSize = (int)Math.Ceiling(totalNumsize);
        //    ViewBag.numSize = numSize;
        //    ViewBag.posts = bks.OrderByDescending(x => x.booking_id).Skip(start).Take(pageSize);
        //    ViewBag.data = bks;
        //    return View(await bks.ToListAsync());
        //    //return View(axContext.ToPagedList(page ?? 1, 5));


        //}

        public async Task<IActionResult> Index(
            string sortOrder,
            string currentFilter,
            string searchString,
            int? pageNumber)
        {
            ViewData["CurrentSort"] = sortOrder;
            ViewData["NameSortParm"] = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            

            if (searchString != null)
            {
                pageNumber = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            ViewData["CurrentFilter"] = searchString;

            var booking = from s in _context.Booking
                         select s;
            if (!String.IsNullOrEmpty(searchString))
            {
                booking = booking.Where(s => s.booking_title.Contains(searchString) || s.participants.Contains(searchString)|| s.note.Contains(searchString));
            }
            booking = booking.OrderByDescending(s => s.booking_id);


            int pageSize = 5;
            return View(await PaginatedList<Booking>.CreateAsync(booking.AsNoTracking(), pageNumber ?? 1, pageSize));
        }

        // GET: Bookings/Create
        public IActionResult Create()
        {
            ViewData["room_id"] = new SelectList(_context.Set<Room>(), "room_id", "room_name");
            ViewData["users_id"] = new SelectList(_context.Set<User_s>(), "users_id", "users_name");
            return View();
        }

        // POST: Bookings/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("booking_id,booking_title,start_time,end_time,participants,note,room_id,users_id")] Booking booking)
        {
            if (ModelState.IsValid)
            {
                _context.Add(booking);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["room_id"] = new SelectList(_context.Set<Room>(), "room_id", "room_name", booking.room_id);
            return View(booking);
        }

        // GET: Bookings/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var booking = await _context.Booking.FindAsync(id);
            if (booking == null)
            {
                return NotFound();
            }
            ViewData["room_id"] = new SelectList(_context.Set<Room>(), "room_id", "room_name", booking.room_id);
            return View(booking);
        }

        // POST: Bookings/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("booking_id,booking_title,start_time,end_time,participants,note,room_id,users_id")] Booking booking)
        {
            if (id != booking.booking_id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(booking);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BookingExists(booking.booking_id))
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
            ViewData["room_id"] = new SelectList(_context.Set<Room>(), "room_id", "room_name", booking.room_id);
            return View(booking);
        }

        // GET: Bookings/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var booking = await _context.Booking
                .Include(b => b.Room)
                .FirstOrDefaultAsync(m => m.booking_id == id);
            if (booking == null)
            {
                return NotFound();
            }

            return View(booking);
        }

        // POST: Bookings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var booking = await _context.Booking.FindAsync(id);
            _context.Booking.Remove(booking);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BookingExists(string id)
        {
            return _context.Booking.Any(e => e.booking_id == id);
        }
    }
}
