namespace Booking_Room.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Booking")]
    public partial class Booking
    {
        [Key]
        [Required(ErrorMessage = "Hãy nhập mã lịch booking phòng họp.")]
        [StringLength(10)]
        [Display(Name = "Mã cuộc họp")]
        public string booking_id { get; set; }

        [Required(ErrorMessage = "Hãy nhập tiêu đề cuộc họp.")]
        [StringLength(100)]
        [Display(Name = "Tiêu đề cuộc họp.")]
        public string booking_title { get; set; }

        [Required(ErrorMessage = "Hãy nhập thời gian bắt đầu cuộc họp.")]
        [Column(TypeName = "smalldatetime")]
        [Display(Name = "Thời gian bắt đầu cuộc họp.")]
        public DateTime start_time { get; set; }

        [Required(ErrorMessage = "Hãy nhập thời gian kết thúc cuộc họp.")]
        [Column(TypeName = "smalldatetime")]
        [Display(Name = "Thời gian kết thúc cuộc họp.")]
        public DateTime end_time { get; set; }

        [StringLength(1000)]
        [Display(Name = "Những người tham gia")]
        public string participants { get; set; }

        [StringLength(1000)]
        [Display(Name = "Ghi chú")]
        public string note { get; set; }

        [Required(ErrorMessage = "Hãy nhập tên phòng họp.")]
        [StringLength(10)]
        [Display(Name = "Tên phòng họp")]
        public string room_id { get; set; }

        [Required(ErrorMessage = "Hãy nhập tên người đặt phòng họp phòng họp.")]
        [StringLength(10)]
        [Display(Name = "Tên người đặt phòng họp")]
        public string users_id { get; set; }

        public virtual Room Room { get; set; }

        public virtual User_s User_s { get; set; }
    }
}
