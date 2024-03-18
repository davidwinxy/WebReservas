using Microsoft.EntityFrameworkCore;
using ReservasEN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservasDAL
{
    public class comunDB : DbContext
    {
        public DbSet<Role> Roles { get; set; }

        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=emmabook\\SQLEXPRESS;Initial Catalog=LoginDB;Integrated Security=True;Trust Server Certificate=True");
        }
    }
}
