using Microsoft.EntityFrameworkCore;
using Reception.Entities.Concrete;

namespace Reception.DataAccess.Concrete;

public class ReceptionContext : DbContext
{
    public DbSet<Room> Rooms { get; set; }
    public DbSet<User> Users { get; set; }

}
