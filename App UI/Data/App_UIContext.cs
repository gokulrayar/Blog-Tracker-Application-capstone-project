using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DAL;

namespace App_UI.Data
{
    public class App_UIContext : DbContext
    {
        public App_UIContext (DbContextOptions<App_UIContext> options)
            : base(options)
        {
        }

        public DbSet<DAL.AdminInfo> AdminInfo { get; set; } = default!;

        public DbSet<DAL.BlogInfo>? BlogInfo { get; set; }

        public DbSet<DAL.EmpInfo>? EmpInfo { get; set; }
    }
}
