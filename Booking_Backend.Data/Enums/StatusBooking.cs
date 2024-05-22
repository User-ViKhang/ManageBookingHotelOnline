using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Booking_Backend.Data.Enums
{
    public enum StatusBooking
    {
        [Display(Name = "Chờ xác nhận")]
        Pedding, //Chờ xử lí
        [Display(Name = "Duyệt đặt phòng")]
        Success, // Đăt phòng thành công
        [Display(Name = "Nhận phòng")]
        Received, // Đã nhận phòng
        [Display(Name = "Trả phòng")]
        Checked, // Đã trả phòng
        [Display(Name = "Hủy đặt phòng")]
        Cancel, // Khách hủy đặt phòng
        [Display(Name = "Không duyệt")]
        Refuse // Khách sạn hủy đặt phòng
    }
}
