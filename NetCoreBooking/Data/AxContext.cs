using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Booking_Room.Models;

namespace NetCoreBooking.Data
{
    public class AxContext : DbContext
    {
        public AxContext (DbContextOptions<AxContext> options)
            : base(options)
        {
        }

        public DbSet<Booking_Room.Models.Booking> Booking { get; set; }

        public DbSet<Booking_Room.Models.User_s> User_s { get; set; }

        public DbSet<Booking_Room.Models.Room> Room { get; set; }
    }
}
