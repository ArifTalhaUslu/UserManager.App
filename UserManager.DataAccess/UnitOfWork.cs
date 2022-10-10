using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserManager.DataAccess.Context;
using UserManager.DataAccess.Repositories.Abstract;
using UserManager.DataAccess.Repositories.Concrete;

namespace UserManager.DataAccess
{
    public class UnitOfWork : IUnitOfWork
    {
        private UserDbContext _context;
        public UnitOfWork(UserDbContext context)
        {
            _context = context;
            UserRepository = new UserService(_context);
        }



        public IUserRepository UserRepository { get; private set; }



        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
