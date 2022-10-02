using System.Collections.Generic;

namespace MagazinSystem.Service.Interfaces
{
    public interface IGenericService<TSource, in TForCreation>
    {
        TSource Create(TForCreation forCreation);
        bool Delete(int id);
        TSource Update(int id, TForCreation forCreation);
        TSource Get(int id);
        IEnumerable<TSource> GetAll();
    }
}
