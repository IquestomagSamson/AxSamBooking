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

namespace NetCoreBooking.Controllers
{
    public class User_sController : Controller
    {
        private readonly AxContext _context;

        public User_sController(AxContext context)
        {
            _context = context;
        }
        public int pageSize = 6;

        //GET: User_s
        public async Task<IActionResult> Index(string seacrhString, int? page)
        {
            var bks = from m in _context.User_s select m;

            if (!String.IsNullOrEmpty(seacrhString))
            {
                ViewBag.seacrhString = seacrhString;

                bks = bks.Where(s => s.User_name.Contains(seacrhString));
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
            ViewBag.posts = bks.OrderByDescending(x => x.User_id).Skip(start).Take(pageSize);

            //var axContext = _context.Booking.Include(b => b.Room).OrderByDescending(m => m.booking_id);
            //return View(await axContext.ToListAsync());
            return View(await bks.ToListAsync());
            //return View(axContext.ToPagedList(page ?? 1, 5));

            /* 
                pageSize: là số bài post mà mình cần hiển thị ra ngoài
                ViewBag.pageCurrent: nhận giá trị page hiện tại
                totalPage: tổng của tất cả dữ liệu bài
                totalNumsize: tổng số trang cần hiển thị
                Math.Ceiling: hàm dùng làm tròn số thập phân
            */
        }


        //public async Task<IActionResult> Index(int page =1)
        //{
        //    //Defining the PageSize
        //    int PageSize = 10;
        //    //Creating the ViewModel's Object
        //    User_sViewModel obj = new User_sViewModel();
        //    DataSet ds = new DataSet();
        //    //List of the Person
        //    List<User_s> lstUser_s = new List<User_s>();

        //    //Connecting to the Database (Here, I am using ADO.Net in order to interact with the database)
        //    //You can use any ORM as per your need or requirement
        //    using (SqlConnection con = new SqlConnection(@"data source=DESKTOP-LRPHS44\SQLEXPRESS;initial catalog=Booking_meeting_room;persist security info=True;user id=sa;password=123"))
        //    {
        //        con.Open();
        //        SqlCommand com = new SqlCommand("getUser", con);
        //        com.CommandType = CommandType.StoredProcedure;
        //        //Passing the Offset value in the procedure
        //        com.Parameters.AddWithValue("@OffsetValue", (page - 1) * PageSize);
        //        com.Parameters.AddWithValue("@PagingSize", PageSize);
        //        SqlDataAdapter adapt = new SqlDataAdapter(com);
        //        //Fill the Dataset and Close the connection
        //        adapt.Fill(ds);
        //        con.Close();
        //        //Bind the data in List of type Person
        //        //We are returning Dataset with two Datatable, one contains the Person Data and Other contains the total records count
        //        if (ds != null && ds.Tables.Count == 2)
        //        {
        //            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
        //            {
        //                User_s objUser = new User_s();
        //                objUser.User_id = Convert.IsDBNull(ds.Tables[0].Rows[i]["User_id"]) ? "" : Convert.ToString(ds.Tables[0].Rows[i]["User_id"]);
        //                objUser.User_name = Convert.IsDBNull(ds.Tables[0].Rows[i]["User_name"]) ? "" : Convert.ToString(ds.Tables[0].Rows[i]["User_name"]);
        //                lstUser_s.Add(objUser);
        //            }
        //            //Passing the TotalRecordsCount, Current Page and Page Size in the constructore of the Pager Class
        //            var pager = new Pager((ds.Tables[1] != null && ds.Tables[1].Rows.Count > 0) ? Convert.ToInt32(ds.Tables[1].Rows[0]["TotalRecords"]) : 0, page, PageSize);
        //            obj.ListUser_s = lstUser_s;
        //            obj.pager = pager;
        //        }
        //    }
        //    return View(obj);
        //}


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
