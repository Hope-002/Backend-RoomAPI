using API.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class RoomDbContext : DbContext
    {
        public RoomDbContext(DbContextOptions<RoomDbContext> options) : base(options) 
        { 
            Database.EnsureCreated();
        }

        public DbSet<Room> Rooms { get; set; }

    }
}
