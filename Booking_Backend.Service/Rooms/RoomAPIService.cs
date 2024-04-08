using Booking_Backend.Data.EF;
using Booking_Backend.Data.Entities;
using Booking_Backend.Data.Enums;
using Booking_Backend.Repository.BookingRepo.ViewModel;
using Booking_Backend.Repository.Common;
using Booking_Backend.Repository.Paging.ViewModel;
using Booking_Backend.Repository.RoomRepo.ViewModel;
using Booking_Backend.Utilities.Exceptions;
using FluentValidation.Resources;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking_Backend.Service.Rooms
{
    public class RoomAPIService : IRoomAPIService
    {
        private readonly BookingContext _context;

        public RoomAPIService(BookingContext context)
        {
            _context = context;
        }

        public async Task<bool> ChangeStatusRoom(int roomId, StatusRoom status)
        {
            var room = await _context.Rooms.FindAsync(roomId);
            if (room == null) throw new BookingException("Phòng không tồn tại");
            room.Status = status;
            _context.Rooms.Update(room);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<APIResult<List<RoomViewModel>>> GetAllRoomByIdHotel(int hotelId, string languageId)
        {
            var rooms = await _context.Rooms
               .Include(r => r.Bed).ThenInclude(b => b.BedTranslations)
               .Include(r => r.RoomType).ThenInclude(rtype => rtype.RoomTypeTranslations)
               .Where(r => r.Hotel_Id == hotelId)
               .ToListAsync();

            if (rooms == null)
            {
                return new APIResult_Error<List<RoomViewModel>>("Không có phòng nào được tìm thấy");
            }

            var roomViewModels = rooms.Select(room => new RoomViewModel
            {
                Id = room.Id,
                RoomCode = room.RoomCode,
                Maximum = room.Maximum,
                PriceOverNight = room.PriceOverNight,
                Status = room.Status,
                Bed = new Bed
                {
                    Id = room.Bed_Id,
                    BedTranslations = room.Bed.BedTranslations.Where(bt => bt.Language_Id == languageId).Select(bt => new BedTranslation
                    {
                        Id = bt.Id,
                        Name = bt.Name,
                        Language_Id = bt.Language_Id
                    }).ToList()
                },
                RoomType = new RoomType
                {
                    Id = room.RoomType_Id,
                    RoomTypeTranslations = room.RoomType.RoomTypeTranslations.Where(rtt => rtt.Language_Id == languageId).Select(rtt => new RoomTypeTranslation
                    {
                        Id = rtt.Id,
                        Name = rtt.Name,
                        Language_Id = rtt.Language_Id,
                    }).ToList()
                }
            }).ToList();

            return new APIResult_Success<List<RoomViewModel>>(roomViewModels);
        }

        public async Task<APIResult<RoomViewModel>> GetRoomByRoomId(int roomId, string languageId)
        {
            var qroom = await _context.Rooms
                .Include(r => r.Bed)
                .Include(r => r.RoomType).ThenInclude(rtt => rtt.RoomTypeTranslations)
                .FirstOrDefaultAsync(r => r.Id == roomId);
            var bed = await _context.Beds
                .Include(bt => bt.BedTranslations)
                .FirstOrDefaultAsync(bt => bt.Id == qroom.Bed_Id);

            if (qroom == null) return new APIResult_Error<RoomViewModel>("Phòng không tồn tại");
            var room = new RoomViewModel
            {
                Id = roomId,
                Maximum = qroom.Maximum,
                PriceOverNight = qroom.PriceOverNight,
                RoomCode = qroom.RoomCode,
                Bed = new Bed
                {
                    Id = bed.Id,
                    BedTranslations = new List<BedTranslation>
            {
                new BedTranslation
                {
                    Id = bed.Id,
                    Name = bed.BedTranslations.FirstOrDefault(x => x.Language_Id == languageId).Name
                }
            }
                },
                RoomType = new RoomType
                {
                    Id = qroom.RoomType_Id,
                    RoomTypeTranslations = new List<RoomTypeTranslation>
                    {
                        new RoomTypeTranslation
                        {
                            Id = qroom.RoomType_Id,
                            Name = qroom.RoomType.RoomTypeTranslations.FirstOrDefault(x => x.Language_Id == languageId).Name
                        }
                    }
                }
            };
            return new APIResult_Success<RoomViewModel>(room);
        }

        public async Task<bool> UpdateRoom(int roomId, RoomViewModel request)
        {
            var room = await _context.Rooms.FindAsync(roomId);
            if (room == null) return false;
            room.Maximum = request.Maximum;
            room.PriceOverNight = request.PriceOverNight;
            room.Bed_Id = request.BedId;
            room.RoomType_Id = request.RoomTypeId;
            room.RoomCode = request.RoomCode;
            try
            {
                _context.Rooms.Update(room);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public async Task<List<Room>> GetRoomsByHotelIdToExtension(int hotelId, string languageId)
        {
            return await _context.Rooms
               .Include(r => r.RoomType).ThenInclude(rt => rt.RoomTypeTranslations)
               .Include(r => r.Bed).ThenInclude(b => b.BedTranslations)
               .Include(r => r.Room_Extensions).ThenInclude(re => re.Extension).ThenInclude(e => e.ExtensionTranslations)
               .Where(r => r.Hotel_Id == hotelId)
               .Select(r => new Room
               {
                   Id = r.Id,
                   RoomCode = r.RoomCode,
                   Maximum = r.Maximum,
                   Status = r.Status,
                   PriceOverNight = r.PriceOverNight,
                   RoomType = new RoomType
                   {
                       Id = r.RoomType.Id,
                       RoomTypeTranslations = r.RoomType.RoomTypeTranslations
                           .Where(rt => rt.Language_Id == languageId)
                           .Select(rt => new RoomTypeTranslation
                           {
                               Id = rt.Id,
                               Name = rt.Name,
                               Language_Id = rt.Language_Id
                           }).ToList()
                   },
                   RoomType_Id = r.RoomType_Id,
                   Bed = new Bed
                   {
                       Id = r.Bed.Id,
                       BedTranslations = r.Bed.BedTranslations
                           .Where(bt => bt.Language_Id == languageId)
                           .Select(bt => new BedTranslation
                           {
                               Id = bt.Id,
                               Name = bt.Name,
                               Description = bt.Description,
                               Language_Id = bt.Language_Id
                           }).ToList()
                   },
                   Bed_Id = r.Bed_Id,
                   Room_Extensions = r.Room_Extensions.Select(re => new Room_Extension
                   {
                       Extension_Id = re.Extension_Id,
                       Extension = new Extension
                       {
                           Id = re.Extension.Id,
                           ExtensionTranslations = re.Extension.ExtensionTranslations
                              .Where(et => et.Language_Id == languageId)
                              .Select(et => new ExtensionTranslation
                              {
                                  Id = et.Id,
                                  Name = et.Name,
                                  Language_Id = et.Language_Id
                              }).ToList()
                       }
                   }).ToList()
               }).ToListAsync();
        }

        public async Task<bool> UpdateRoom_Extension(List<int> IdsExtension, int roomId)
        {
            // Get the hotel
            var room = _context.Rooms.FirstOrDefault(r => r.Id == roomId);

            if (room == null)
            {
                // Handle hotel not found
                return false;
            }

            // Get the existing service ids for the hotel
            var existingExtensionIds = _context.Room_Extensions.Where(x=>x.Room_Id==roomId).Select(re => re.Extension_Id).ToList();

            // Find the service ids to add
            var extensionIdsToAdd = IdsExtension.Where(id => !existingExtensionIds.Contains(id)).ToList();

            // Find the service ids to remove
            var extensionIdsToRemove = existingExtensionIds.Where(id => !IdsExtension.Contains(id)).ToList();

            // Add new services
            foreach (var extensionId in extensionIdsToAdd)
            {
                var roomExtension = new Room_Extension
                {
                    Room_Id = roomId,
                    Extension_Id = extensionId
                };

                _context.Room_Extensions.Add(roomExtension);
            }

            // Remove old services
            foreach (var extensionId in extensionIdsToRemove)
            {
                var extensionRoom = _context.Room_Extensions.FirstOrDefault(hs => hs.Extension_Id == extensionId && hs.Room_Id == roomId);

                if (extensionRoom != null)
                {
                    _context.Room_Extensions.Remove(extensionRoom);
                }
            }

            // Save changes
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
