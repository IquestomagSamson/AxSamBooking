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
        [Required(ErrorMessage = "Hãy nhập mã người dùng")]
        [StringLength(10)]
        [Display(Name ="User ID")]
        public string User_id { get; set; }

        [Required(ErrorMessage = "Hãy nhập tên người dùng")]
        [StringLength(50)]
        [Display(Name = "User name")]
        public string User_name { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Booking> Bookings { get; set; }
       
    }
  
}
