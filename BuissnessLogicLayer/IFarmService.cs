using DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuissnessLogicLayer
{
    public interface IFarmService
    {
        Task<IEnumerable<FarmModel>> GetFarmsAsync();
    }
}
