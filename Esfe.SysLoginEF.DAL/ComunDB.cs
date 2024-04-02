
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Esfe.SysLoginEF.EN;

//
using Microsoft.EntityFrameworkCore;

namespace Esfe.SysLoginEF.DAL
{
    public class ComunDB : DbContext
    {
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-FH4JPSE\\MENA07;Initial Catalog=LoginDB;Integrated Security=True;Trust Server Certificate=True");
        }

    }
}
