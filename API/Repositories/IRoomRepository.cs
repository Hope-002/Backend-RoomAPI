using API.Models;

namespace API.Repositories
{
    public interface IRoomRepository
    {
        Task<IEnumerable<Room>> Get();
        Task<Room> Get(int RoomId);
        Task<Room> Create(Room room);
        Task Update(Room room);
        Task Delete(int RoomId);
    }
}
