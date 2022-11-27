using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SalesWebCore.Models;

namespace SalesWebCore.Data
{
    public class SalesWebCoreContext : DbContext
    {
        public SalesWebCoreContext (DbContextOptions<SalesWebCoreContext> options)
            : base(options)
        {
        }

        public DbSet<SalesWebCore.Models.Department> Department { get; set; }
    }
}
