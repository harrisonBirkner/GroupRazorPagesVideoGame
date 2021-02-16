using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GroupRazorPagesVideoGame.Models;

namespace GroupRazorPagesVideoGame.Data
{
    public class GroupRazorPagesVideoGameContext : DbContext
    {
        public GroupRazorPagesVideoGameContext (DbContextOptions<GroupRazorPagesVideoGameContext> options)
            : base(options)
        {
        }

        public DbSet<GroupRazorPagesVideoGame.Models.CustomerInfo> CustomerInfo { get; set; }
    }
}
