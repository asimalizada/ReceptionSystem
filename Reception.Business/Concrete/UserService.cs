using Reception.Business.Asbtract;
using Reception.DataAccess.Abstract;
using Reception.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reception.Business.Concrete;
public class UserService : BaseService<User, IUserRepository>, IUserService
{
    public UserService(IUserRepository repository) : base(repository)
    {
    }
}
