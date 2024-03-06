using System;
using System.Collections.Generic;
using System.Text;

namespace Booking_Backend.Data.Enums
{
    public enum StatusBooking
    {
        Pedding, //Chờ xử lí
        Handling, // Đang xử lí
        Success, // Đăt phòng thành công
        Received, // Đã nhận phòng
        Checked, // Đã trả phòng
        Cancel, // Khách hủy đặt phòng
        Refuse // Khách sạn hủy đặt phòng
    }
}
