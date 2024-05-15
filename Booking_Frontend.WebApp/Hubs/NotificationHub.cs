using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace Booking_Frontend.WebApp.Hubs
{
    public class NotificationHub : Hub
    {
        public async Task NotifyHotelOwner(string hotelOwnerId, string message)
        {
            await Clients.All.SendAsync("ReceiveNotification", hotelOwnerId, message);
        }
    }
}
