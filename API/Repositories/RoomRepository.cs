using API.Data;
using API.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Repositories
{
    public class RoomRepository : IRoomRepository
    {
        private readonly RoomDbContext _context;
        public RoomRepository(RoomDbContext context)
        {
            _context= context;
        }
        public async Task<Room> Create(Room room)
        {
            _context.Rooms.Add(room);
            await _context.SaveChangesAsync();

            return room;
        }

        public async Task Delete(int id)
        {
            var roomToDelete = await _context.Rooms.FindAsync(id);
            _context.Rooms.Remove(roomToDelete);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Room>> Get()
        {
            return await _context.Rooms.ToListAsync();
        }

        public async Task<Room> Get(int id)
        {
            return await _context.Rooms.FindAsync(id);
        }

        public async Task Update(Room room)
        {
            _context.Entry(room).State = EntityState.Modified;
            await _context.SaveChangesAsync();

        }
    }
}
