using DataAccessLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataAccessLayer.Data
{
    public class FarmDbContext : DbContext
    {
        public FarmDbContext(DbContextOptions options) : base(options) { }
        public DbSet<FarmModel> Farms { get; set; }
        
    }
}
