using System.Collections.Generic;
using LabTest.Domain.Entities;

namespace LabTest.Domain.Interfaces.Repositories
{
    public interface IBrandRepository : IRepository<Brand>
    {
        IEnumerable<Brand> GetAll();
        Brand GetByName(string name);
    }
}