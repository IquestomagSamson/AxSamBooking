namespace Booking_Room.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
   

    public partial class User_s
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User_s()
        {
            Bookings = new HashSet<Booking>();
        }

        [Key]
        [StringLength(10)]
        [Display(Name ="User ID")]
        public string User_id { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "User name")]
        public string User_name { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Booking> Bookings { get; set; }
       
    }
    //public class User_sViewModel
    //{
    //    public List<User_s> ListUser_s { get; set; }
    //    public Pager pager { get; set; }
    //}

    //public class Pager
    //{
    //    public Pager(int totalItems, int? page, int pageSize = 10)
    //    {
    //        // Total Paging need to show
    //        int _totalPages = (int)Math.Ceiling((decimal)totalItems / (decimal)pageSize);
    //        //Current Page
    //        int _currentPage = page != null ? (int)page : 1;
    //        //Paging to be starts with
    //        int _startPage = _currentPage - 5;
    //        //Paging to be end with
    //        int _endPage = _currentPage + 4;
    //        if (_startPage <= 0)
    //        {
    //            _endPage -= (_startPage - 1);
    //            _startPage = 1;
    //        }
    //        if (_endPage > _totalPages)
    //        {
    //            _endPage = _totalPages;
    //            if (_endPage > 10)
    //            {
    //                _startPage = _endPage - 9;
    //            }
    //        }
    //        //Setting up the properties
    //        TotalItems = totalItems;
    //        CurrentPage = _currentPage;
    //        PageSize = pageSize;
    //        TotalPages = _totalPages;
    //        StartPage = _startPage;
    //        EndPage = _endPage;
    //    }
    //    public int TotalItems { get; set; }
    //    public int CurrentPage { get; set; }
    //    public int PageSize { get; set; }
    //    public int TotalPages { get; set; }
    //    public int StartPage { get; set; }
    //    public int EndPage { get; set; }
    //}
}
