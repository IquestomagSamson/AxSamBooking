using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace NetCoreBooking_PagedList
{
    public class PaginatedList<T> : List<T>
    {
        // Chỉ số trang
        public int PageIndex { get; private set; }
        //Đếm xem có bao nhiêu page được tính ra
        public int TotalPages { get; private set; }

        public PaginatedList(List<T> items, int count, int pageIndex, int pageSize)
        {
            // Lấy pageIndex được truyền vào trong controller
            PageIndex = pageIndex;
            // Tính tổng số trang dựa trên số bản ghi và số lượng bản ghi được phép hiển thị trên từng page
            TotalPages = (int)Math.Ceiling(count / (double)pageSize);
            
            //Thêm các phần tử của một ICollection vào phần cuối của ArrayList
            this.AddRange(items);
        }
        //Được thực hiện khi đang ở trang thứ 2 đến trang thứ n
        public bool HasPreviousPage
        {
            get
            {
                return (PageIndex > 1);
            }
        }
        // Được thực hiện khi ở trang thứ 1 đến trang thứ n-1
        public bool HasNextPage
        {
            get
            {
                return (PageIndex < TotalPages);
            }
        }

        public static async Task<PaginatedList<T>> CreateAsync(IQueryable<T> source, int pageIndex, int pageSize)
        {

            var count = await source.CountAsync();

            var items = await source.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToListAsync();
           
            return new PaginatedList<T>(items, count, pageIndex, pageSize);
        }
    }
}