using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PostgreSQLDB.Models;
//using Microsoft.IdentityModel.Clients.ActiveDirectory;

namespace PostgreSQLDB.DB
{
    public class PostgreSQLDBContext : IdentityDbContext
    {
        public PostgreSQLDBContext(DbContextOptions<PostgreSQLDBContext> options) : base(options) { }
        public DbSet<User> Users { get; set; }
        public DbSet<Group> Groups { get; set; }
    }
}
