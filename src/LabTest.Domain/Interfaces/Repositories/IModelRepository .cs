using System.Collections.Generic;
using LabTest.Domain.Entities;

namespace LabTest.Domain.Interfaces.Repositories
{
    public interface IModelRepository : IRepository<Model>
    {
        IEnumerable<Brand> GetAllByBrand(int brandId);
    }
}