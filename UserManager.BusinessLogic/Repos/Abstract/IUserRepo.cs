using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserManager.Entity.Entities;

namespace UserManager.BusinessLogic.Repos.Abstract
{
    public interface IUserRepo
    {
        public int AddUser(User entity);
        public Task<int> AddUserAsync(User entity);
        public int DeleteUser(User entity);
        public Task<int> DeleteUserAsync(User entity);
        public int DeleteById(int id);
        public Task<int> DeleteByIdAsync(int id);
        public int UpdateUser(User entity);
        public Task<int> UpdateUserAsync(User entity);
        public User GetById(int id);
        public Task<User> GetByIdAsync(int id);
        public IEnumerable<User> GetAll();
        public Task<IEnumerable<User>> GetAllAsync();
    }
}
