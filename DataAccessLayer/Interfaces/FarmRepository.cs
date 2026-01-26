using DataAccessLayer.Data;
using DataAccessLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Interfaces
{
    public class FarmRepository : IFarmRepository
    {
        private readonly FarmDbContext farmDbContext;

        public FarmRepository(FarmDbContext farmDbContext)
        {
            this.farmDbContext = farmDbContext;
        }

        public async Task<IEnumerable<FarmModel>> GetFarmsAsync() 
        { 
            return await farmDbContext.Farms.ToListAsync();
        }
    }
}
