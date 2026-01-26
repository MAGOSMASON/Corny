using DataAccessLayer.Entities;
using DataAccessLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuissnessLogicLayer
{
    public class FarmService : IFarmService
    {
        private readonly IFarmRepository farmRepository;
        public FarmService(IFarmRepository farmRepository)
        {
            this.farmRepository = farmRepository;
        }

        public async Task<IEnumerable<FarmModel>> GetFarmsAsync() 
        { 
            return await farmRepository.GetFarmsAsync();
        }
    }
}
