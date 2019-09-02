using DatingApp.API.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatingApp.API.Data
{
    public class DatingDbContext:DbContext
    {
        public DatingDbContext(DbContextOptions<DatingDbContext> options) : base(options){ }

        public DbSet<Value> Values { get; set; }
    }
}
