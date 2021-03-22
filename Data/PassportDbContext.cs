using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PassportApi.Models;

namespace PassportApi.Data
{
    public class PassportDbContext : DbContext
    {
        public PassportDbContext (DbContextOptions<PassportDbContext> options)
            : base(options)
        {
        }

        public DbSet<PassportApi.Models.Passport> Passport { get; set; }
    }
}
