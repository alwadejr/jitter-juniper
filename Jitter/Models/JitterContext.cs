using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Jitter.Models
{
    public class JitterContext : DbContext
    {
        public DbSet<JitterUser> JitterUsers { get; set; }
        public DbSet<Jot> Jots { get; set; }

    }
}
