using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserManager.Entity.Entities;

namespace UserManager.DataAccess.Repositories.Abstract
{
    public interface IUserRepository : IGenericRepository<User>
    {
    }
}
