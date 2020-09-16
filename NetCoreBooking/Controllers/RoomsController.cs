using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Booking_Room.Models;
using NetCoreBooking.Data;
using NetCoreBooking_PagedList;
using static NetCoreBooking.Enums.Enums;
namespace NetCoreBooking.Controllers
{
    public class RoomsController : BaseNotification
    {
        private readonly AxContext _context;
        //Read comment in Booking controller and UserController
        
        public RoomsController(AxContext context)
        {
            _context = context;
        }
      
        public async Task<IActionResult> Index(string sortOrder, string currentFilter, string searchString, int? pageNumber)
        {
            ViewData["CurrentSort"] = sortOrder;
            ViewData["NameSortParm"] = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            //Nếu chuỗi truyền vào mà không rỗng thì pageNumber bằng 1
            if (searchString != null)
            {
                pageNumber = 1;
            }
            ///
            //Ngược lại thì searchString bằng currentFilter
            else
            {
                searchString = currentFilter;
            }

            ViewData["CurrentFilter"] = searchString;

            var room = from s in _context.Room
                       select s;
            if (!String.IsNullOrEmpty(searchString))
            {
                room = room.Where(s => s.room_name.Contains(searchString));
            }
            room = room.OrderByDescending(s => s.room_id);

            int pageSize = 10;
            return View(await PaginatedList<Room>.CreateAsync(room.AsNoTracking(), pageNumber ?? 1, pageSize));
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
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("room_id,room_name,capacity")] Room room)
        {
            if (ModelState.IsValid) //ModelState.IsValid: mang giá trị false khi 1 (false) thuộc tính nào đó mang giá trị không hợp lệ.
            {
                try
                {

                    _context.Add(room);
                    await _context.SaveChangesAsync();
                    Alert("Tạo mới phòng họp thành công", NotificationType.success);
                    Message("Tạo mới phòng họp thành công", NotificationType.success);
                    return RedirectToAction(nameof(Index));
                }
                catch
                {
                    Alert("Tạo mới phòng họp không thành công", NotificationType.error);
                    Message("Tạo mới phòng họp không thành công", NotificationType.error);
                    return RedirectToAction(nameof(Index));
                }
                
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
                    Alert("Sửa phòng họp thành công", NotificationType.success);
                    Message("Sửa phòng họp thành công", NotificationType.success);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RoomExists(room.room_id))
                    {
                        Alert("Sửa phòng họp không thành công", NotificationType.error);
                        Message("Sửa phòng họp không thành công", NotificationType.error);
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
            try
            {
                _context.Room.Remove(room);
                await _context.SaveChangesAsync();
                Alert("Xóa phòng họp thành công", NotificationType.success);
                Message("Xóa phòng họp thành công", NotificationType.success);
                return RedirectToAction(nameof(Index));

            }

            catch
            {
                Alert("Xóa phòng họp không thành công", NotificationType.error);
                Message("Xóa phòng họp không thành công", NotificationType.error);
                return RedirectToAction(nameof(Index));
            }
            
            //_context.Room.Remove(room);
            //await _context.SaveChangesAsync();
            //return RedirectToAction(nameof(Index));
        }

        private bool RoomExists(string id)
        {
            return _context.Room.Any(e => e.room_id == id);
        }
    }
}
