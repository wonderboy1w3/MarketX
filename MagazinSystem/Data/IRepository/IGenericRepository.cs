using MagazinSystem.Domain.Entities;
using System.Collections.Generic;

namespace MagazinSystem.Data.IRepository
{
    public interface IGenericRepository<T> where T : Auditable
    {
        T Create(T source);
        bool Delete(long id);
        T Update(long id, T source);
        T Get(long id);
        IEnumerable<T> GetAll();
    }
}
