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
using static NetCoreBooking.Enums.Enums;


namespace NetCoreBooking.Controllers
{
    public class BookingsController : BaseNotification
    {
        private readonly AxContext _context;

        public BookingsController(AxContext context)
        {
            _context = context;
        }
        //Tạo mới một context
        public AxContext db = new AxContext();
        public async Task<IActionResult> Index(string sortOrder, string currentFilter, string searchString, int? pageNumber)
        {
            ViewData["CurrentSort"] = sortOrder;
            ViewData["NameSortParm"] = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";

            //Nếu chuỗi tìm kiếm được truyền vào khồng rỗng thì trả về page đầu tiên
            if (searchString != null)
            {
                pageNumber = 1;
            }
            // Ngược lại không trả về danh sách nào
            else
            {
                searchString = currentFilter;
            }
            //Trả về  CurrentFilter có giá trị là chuỗi searchString
            ViewData["CurrentFilter"] = searchString;
            //Select dữ liệu 
            var booking = from s in _context.Booking
                          select s;
            //Nếu search không rỗng hoặc null thì tìm các bản ghi có chứa searchString
            if (!String.IsNullOrEmpty(searchString))
            {
                booking = booking.Where(s => s.booking_title.Contains(searchString) || s.participants.Contains(searchString) || s.note.Contains(searchString));
            }
            //Sắp xếp lại theo id của lịch booking phòng họp
            booking = booking.OrderByDescending(s => s.booking_id);
            //Set số lượng bản ghi hiện lên mỗi page là 5
            int pageSize = 10;
            //Trả về View
            return View(await PaginatedList<Booking>.CreateAsync(booking.AsNoTracking(), pageNumber ?? 1, pageSize));
        }

        // GET: Bookings/Create
        public IActionResult Create()
        {
            //Tạo các Viewdata (data dictionary) để hiển thị danh sách dữ liệu
            ViewData["room_id"] = new SelectList(_context.Set<Room>(), "room_id", "room_name");
            ViewData["users_id"] = new SelectList(_context.Set<User_s>(), "User_id", "User_name");
            return View();
        }

        // POST: Bookings/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        //Hỗ trợ chống giả mạo của MVC ghi một giá trị duy nhất vào cookie chỉ có HTTP và sau đó cùng một giá trị được ghi vào biểu mẫu.
        //Khi trang được gửi, một lỗi sẽ xuất hiện nếu giá trị cookie không khớp với giá trị biểu mẫu. 
        public async Task<IActionResult> Create([Bind("booking_id,booking_title,start_time,end_time,participants,note,room_id,users_id")] Booking booking)
        {
            if (ModelState.IsValid) //ModelState.IsValid: mang giá trị false khi 1 (false) thuộc tính nào đó mang giá trị không hợp lệ.
            {
                if(booking.start_time<booking.end_time)
                {
                    try
                    {
                        _context.Add(booking);
                        await _context.SaveChangesAsync();
                        Alert("Tạo mới lịch thành công", NotificationType.success);
                        Message("Tạo mới lịch thành công", NotificationType.success);
                        return RedirectToAction(nameof(Index));
                    }
                    catch (Exception e)
                    {
                        //Alert(e.ToString(), NotificationType.error);
                        Alert("Trùng mã. Tạo mới lịch thất bại", NotificationType.error);
                        Message("Trùng mã. Tạo mới lịch không thành công", NotificationType.error);
                        //return RedirectToAction(nameof(Index));
                    }
                }  
                else
                {
                    Alert("Hãy nhập đúng thứ tự ngày, thời gian bắt đầu phải nhỏ hơn thời gian kết thúc", NotificationType.error);
                    Message("Hãy nhập đúng thứ tự ngày, thời gian bắt đầu phải nhỏ hơn thời gian kết thúc", NotificationType.error);
                    return RedirectToAction(nameof(Index));

                }    
               
                // Redirect về trang index sau khi tạo xong

                
            }


            ViewData["room_id"] = new SelectList(_context.Set<Room>(), "room_id", "room_name", booking.room_id);
            ViewData["users_id"] = new SelectList(_context.Set<User_s>(), "User_id", "User_name", booking.users_id);
            
            return View(booking);
        }

        // GET: Bookings/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            //Trả về null khi giá trị muốn edit không tồn tại
            if (id == null)
            {
                return NotFound();
            }

            var booking = await _context.Booking.FindAsync(id);
            if (booking == null)
            {
                return NotFound();
            }

            ViewData["room_id"] = new SelectList(_context.Set<Room>(), "room_id", "room_name");
            ViewData["users_id"] = new SelectList(_context.Set<User_s>(), "User_id", "User_name");
            return View(booking);
        }

        // POST: Bookings/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("booking_id,booking_title,start_time,end_time,participants,note,room_id,users_id")] Booking booking)
        {
            //Nếu mã không tồn tại thì không thể sửa (Xảy ra khi thực hiện truyền trực tiếp trên link
            if (id != booking.booking_id)
            {
                return NotFound();
            }
            // Nếu tồn tại ID ở trên thì thực hiện sửa Booking có ID được truyền vào
            if (ModelState.IsValid)
            {
                // Thực hiện try sửa một booking bằng việc check các trường đi kèm
                try
                {
                    _context.Update(booking);
                    Alert("Sửa lịch thành công", NotificationType.success);
                    Message("Sửa lịch thành công", NotificationType.success);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    //Nếu không tồn tại một booking nào có mã booking id thì sẽ không trả về dữ liệu
                    if (!BookingExists(booking.booking_id))
                    {
                        Alert("Sửa lịch thất bại", NotificationType.error);
                        Message("Sửa lịch không thành công", NotificationType.error);
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                   
                }
                //Redirect đến trang index sau khi thực hiện xong tác vụ
                return RedirectToAction(nameof(Index));
            }
            ViewData["room_id"] = new SelectList(_context.Set<Room>(), "room_id", "room_name", booking.room_id);
            ViewData["users_id"] = new SelectList(_context.Set<User_s>(), "User_id", "User_name", booking.users_id);
            return View(booking);
        }

        // GET: Bookings/Delete/5
        public async Task<IActionResult> Delete(string id)
        {

            //Nếu id truyền vào mà không tồn tại thì không trả về dữ liệu
            if (id == null)
            {
                return NotFound();
            }

            var booking = await _context.Booking
                //.Include(b => b.Room)
                .FirstOrDefaultAsync(m => m.booking_id == id);
            //Nếu booking null thì không trẩ về dữ liệu
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
            try
            {
                _context.Booking.Remove(booking);
                await _context.SaveChangesAsync();
                Alert("Xóa lịch thành công", NotificationType.success);
                Message("Xóa lịch thành công", NotificationType.success);
                return RedirectToAction(nameof(Index));
            }
            catch(Exception)
            {
                Alert("Xóa lịch thất bại", NotificationType.error);
                Message("Xóa lịch không thành công", NotificationType.error);
                return RedirectToAction(nameof(Index));
            }
           
            
        }
        //Xác định khi nào bất kỳ phần tử nào trong tập dữ liệu thỏa mãn yêu cầu nào đó.
        private bool BookingExists(string id)
        {
            //Xác định khi nào bất kỳ phần tử nào trong tập dữ liệu thỏa mãn yêu cầu nào đó.
            return _context.Booking.Any(e => e.booking_id == id);
        }
    }
}
