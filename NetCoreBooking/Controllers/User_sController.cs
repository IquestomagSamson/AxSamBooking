using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Booking_Room.Models;
using NetCoreBooking.Data;
using PagedList;
using System.Data;
using System.Data.SqlClient;
using Microsoft.IdentityModel.Protocols;
using NetCoreBooking_PagedList;

namespace NetCoreBooking.Controllers
{
    public class User_sController : Controller
    {
        private readonly AxContext _context;

        public User_sController(AxContext context)
        {
            _context = context;
        }
        
        public async Task<IActionResult> Index(
            string sortOrder,
            string currentFilter,
            string searchString,
            int? pageNumber)
        {
            ViewData["CurrentSort"] = sortOrder;
            ViewData["NameSortParm"] = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            //PageNumber bằng 1 nếu như searchString khác null
            if (searchString != null)
            {
                pageNumber = 1;
            }
            //Ngược lại sẽ bằng currentFilter
            else
            {
                searchString = currentFilter;
            }
            // Gán currentFilter bằng chuỗi searchString
            ViewData["CurrentFilter"] = searchString;
            // Truy vấn các bản ghi có tong bảng User
            var user_s = from s in _context.User_s
                           select s;
            //Nếu search không rỗng hoặc null thì tìm các bản ghi có chứa searchString
            if (!String.IsNullOrEmpty(searchString))
            {
                //Tìm các user có tên mà chứa từ khóa bằng với chuỗi searchStrig vừa truyền vào
                user_s = user_s.Where(s => s.User_name.Contains(searchString));
            }
            //Sắp xếp dữ liệu trả về theo thứ tự giảm dần của user Id
            user_s = user_s.OrderByDescending(s => s.User_id);
           //Set số lượng bản ghi được phép xuất hiện trong một màn trang
            int pageSize = 5;
            return View(await PaginatedList<User_s>.CreateAsync(user_s.AsNoTracking(), pageNumber ?? 1, pageSize));
        }

        // GET: User_s/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user_s = await _context.User_s
                //Không đồng bộ trả về phần tử đầu tiên của một chuỗi hoặc một giá trị mặc định nếu chuỗi không chứa phần tử nào.
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
       
        [HttpPost]
        [ValidateAntiForgeryToken]
        //Hỗ trợ chống giả mạo của MVC ghi một giá trị duy nhất vào cookie chỉ có HTTP và sau đó cùng một giá trị được ghi vào biểu mẫu.
        //Khi trang được gửi, một lỗi sẽ xuất hiện nếu giá trị cookie không khớp với giá trị biểu mẫu. 

        public async Task<IActionResult> Create([Bind("User_id,User_name")] User_s user_s)
        {
            if (ModelState.IsValid)//ModelState.IsValid: mang giá trị false khi 1 (false) thuộc tính nào đó mang giá trị không hợp lệ.
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
            //Tìm một người dùng khi người đó có id được truyền vào
            var user_s = await _context.User_s.FindAsync(id);
            if (user_s == null)
            {
                return NotFound();
            }
            return View(user_s);
        }

        // POST: User_s/Edit/5
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("User_id,User_name")] User_s user_s)
        {
            if (id != user_s.User_id)
            {
                return NotFound();
            }

            if (ModelState.IsValid) //ModelState.IsValid: mang giá trị false khi 1 (false) thuộc tính nào đó mang giá trị không hợp lệ.
            {
                // Try cập nhật dữ liệu khi dữ liệu hợp lệ
                try
                {
                    _context.Update(user_s);
                    await _context.SaveChangesAsync();
                }
                // Nếu không hợp lện thì kiểm tra sai và ném ra lỗi
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
                //Redirect đến trang index sau khi thực hiên xong tác vụ
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
            //Tìm kiếm một người dùng khi người đó có ID là ID được truyền vào
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
        //Xác nhận lại thông tin rằng có muốn xóa người dùng có ID là ID được truyền vào hay không
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var user_s = await _context.User_s.FindAsync(id);
            _context.User_s.Remove(user_s);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        // Tìm những người dùng có id là id được truyền vào
        private bool User_sExists(string id)
        {
            return _context.User_s.Any(e => e.User_id == id);
        }
    }
}
