using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi_LaminacionBLBP.Models
{
    public class LamblbpDetailContext: DbContext
    {
        public LamblbpDetailContext(DbContextOptions<LamblbpDetailContext> options):base(options)
        {

        }
        public DbSet<LamblbpDetail> LamblbpDetails { get; set; }
    }
}
