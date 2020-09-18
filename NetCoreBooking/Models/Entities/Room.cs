namespace Booking_Room.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    [Table("Room")]
    public partial class Room
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Room()
        {
            Bookings = new HashSet<Booking>();
        }

        [Key]
        [Required(ErrorMessage = "Hãy nhập mã phòng họp")]
        [StringLength(10)]
        [Display(Name = "Mã phòng họp")]
        public string room_id { get; set; }

        [Required(ErrorMessage = "Hãy nhập tên phòng họp")]
        [StringLength(50)]
        [Display(Name = "Tên phòng họp")]
        public string room_name { get; set; }


        [Required(ErrorMessage = "Hãy nhập số người tối đa có thể chưa trong phòng họp")]
        [Display(Name = "Sức chứa của phòng")]
        public int capacity { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Booking> Bookings { get; set; }
    }
}
