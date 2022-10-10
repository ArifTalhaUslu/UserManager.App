using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserManager.DataAccess.Context;
using UserManager.DataAccess.Repositories.Abstract;
using UserManager.Entity.Entities;

namespace UserManager.DataAccess.Repositories.Concrete
{
    public class UserService : GenericRepository<User>, IUserRepository
    {
        public UserService(UserDbContext dbContext) : base(dbContext)
        {
        }

    }
}
