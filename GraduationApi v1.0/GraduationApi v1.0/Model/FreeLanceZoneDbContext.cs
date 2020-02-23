using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraduationApi_v1._0.Model
{
    public class FreeLanceZoneDbContext:DbContext
    {
        public FreeLanceZoneDbContext(DbContextOptions<FreeLanceZoneDbContext> options) :base(options)
        {

        }
        public  DbSet<User> Users { get; set; }
        public DbSet<Intern> Interns { get; set; }
        public DbSet<Role> Roles { get; set; }
    }
}
