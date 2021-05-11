using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MeTracker.Models;

namespace MeTracker.Repositories
{
    public interface ILocationRepository
    {
        Task Save(Location location);
        Task<List<Location>> GetAll();
    }
}
