using Reception.Entities.Abstract;

namespace Reception.Entities.Concrete;
public class User : IEntity
{
    public int Id { get; set; }
    public string UserName { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string FullName
    {
        get => FirstName + " " + LastName;
    }
    public string Email { get; set; }
    public string PasswordHash { get; set; }
}
