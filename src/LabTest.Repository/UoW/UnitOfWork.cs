using LabTest.Domain.Interfaces.Repositories;

namespace LabTest.Repository.UoW
{
    class UnitOfWork : IUnitOfWork
    {
        public bool Commit()
        {
            return true;
        }
    }
}
