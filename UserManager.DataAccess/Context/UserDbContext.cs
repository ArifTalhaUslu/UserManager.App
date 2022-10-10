using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserManager.Entity.Entities;

namespace UserManager.DataAccess.Context
{
    public class UserDbContext : DbContext
    {
        public DbSet<User> UserInfos { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=UserCrudDb;Integrated Security=true");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //For Users
            modelBuilder.Entity<User>().Property(d => d.UserName).HasColumnType("VARCHAR").HasMaxLength(150).IsRequired();
            modelBuilder.Entity<User>().Property(d => d.PhoneNumber).HasColumnType("VARCHAR").HasMaxLength(13).IsRequired();
            modelBuilder.Entity<User>().Property(d => d.Password).HasColumnType("VARCHAR").HasMaxLength(800).IsRequired();
            modelBuilder.Entity<User>().HasIndex(d => d.Email).IsUnique(true);

            //For another models
            //.
            //.
            //.
        }
    }
}
