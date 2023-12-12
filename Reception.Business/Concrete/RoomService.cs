using Reception.Business.Asbtract;
using Reception.DataAccess.Abstract;
using Reception.Entities.Concrete;

namespace Reception.Business.Concrete;

public class RoomService : BaseService<Room, IRoomRepository>, IRoomService
{
    public RoomService(IRoomRepository repository) : base(repository)
    {

    }
}
