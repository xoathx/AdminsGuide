using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdminsGuide.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace AdminsGuide.Data
{
    public class DBContext : DbContext
    {
        public DBContext(DbContextOptions<DBContext> options) : base(options) { }

        public DbSet<Guide> Guides { get; set; }
    }
}
