using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserManager.BusinessLogic.Repos.Abstract;
using UserManager.Common;
using UserManager.DataAccess;
using UserManager.Entity.Entities;

namespace UserManager.BusinessLogic.Repos.Concrete
{
    public class UserRepo : IUserRepo
    {
        public int AddUser(User entity)
        {
            using (IUnitOfWork _unit = new UnitOfWork(new DataAccess.Context.UserDbContext()))
            {
                return _unit.UserRepository.Add(entity);
            }
        }
        public async Task<int> AddUserAsync(User entity)
        {
            using (IUnitOfWork _unit = new UnitOfWork(new DataAccess.Context.UserDbContext()))
            {
                return await _unit.UserRepository.AddAsync(entity);
            }
        }


        public int DeleteUser(User entity)
        {
            using (IUnitOfWork _unit = new UnitOfWork(new DataAccess.Context.UserDbContext()))
            {
                return _unit.UserRepository.Delete(entity);
            }
        }
        public async Task<int> DeleteUserAsync(User entity)
        {
            using (IUnitOfWork _unit = new UnitOfWork(new DataAccess.Context.UserDbContext()))
            {
               return await _unit.UserRepository.DeleteAsync(entity);
            }
        }
        public int DeleteById(int id)
        {
            using (IUnitOfWork _unit = new UnitOfWork(new DataAccess.Context.UserDbContext()))
            {
                return _unit.UserRepository.Delete(id);
            }
        }
        public async Task<int> DeleteByIdAsync(int id)
        {
            using (IUnitOfWork _unit = new UnitOfWork(new DataAccess.Context.UserDbContext()))
            {
                return await _unit.UserRepository.DeleteAsync(id);
            }
        }

        public int UpdateUser(User entity)
        {
            using (IUnitOfWork _unit = new UnitOfWork(new DataAccess.Context.UserDbContext()))
            {
                return _unit.UserRepository.Update(entity);
            }
        }
        public async Task<int> UpdateUserAsync(User entity)
        {
            using (IUnitOfWork _unit = new UnitOfWork(new DataAccess.Context.UserDbContext()))
            {
                return await _unit.UserRepository.UpdateAsync(entity);
            }
        }

        public User GetById(int id)
        {
            using (IUnitOfWork _unit = new UnitOfWork(new DataAccess.Context.UserDbContext()))
            {
                return _unit.UserRepository.GetById(id);
            }
        }
        public async Task<User> GetByIdAsync(int id)
        {
            using (IUnitOfWork _unit = new UnitOfWork(new DataAccess.Context.UserDbContext()))
            {
                return await _unit.UserRepository.GetByIdAsync(id);
            }
        }


        public IEnumerable<User> GetAll()
        {
            using (IUnitOfWork _unit = new UnitOfWork(new DataAccess.Context.UserDbContext()))
            {
                return _unit.UserRepository.GetAll();
            }
        }
        public async Task<IEnumerable<User>> GetAllAsync()
        {
            using (IUnitOfWork _unit = new UnitOfWork(new DataAccess.Context.UserDbContext()))
            {
                return await _unit.UserRepository.GetAllAsync();
            }
        }
    }
}
