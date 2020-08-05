using System;

namespace LabTest.Domain.Interfaces.Repositories
{
    public interface IRepository<T> : IDisposable where T : class
    {
        T Add(T obj);
        T Update(T obj);
        T Delete(T obj);
        T GetById(Guid id);
        int SaveChanges();
    }
}