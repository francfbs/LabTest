using System.Collections.Generic;
using LabTest.Domain.Entities;

namespace LabTest.Domain.Interfaces.Repositories
{
    public interface IVehicleRepository : IRepository<Vehicle>
    {
        IEnumerable<Vehicle> GetAllByModel(int modelId);
    }
}