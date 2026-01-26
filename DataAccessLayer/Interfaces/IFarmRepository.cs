using DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Interfaces
{
    public interface IFarmRepository
    {
        //add in tasks here first
        //then add tasks in regular repository
        //thrn add tasks into iservice
        //then add to just service

        Task<IEnumerable<FarmModel>> GetFarmsAsync();

    }
}
