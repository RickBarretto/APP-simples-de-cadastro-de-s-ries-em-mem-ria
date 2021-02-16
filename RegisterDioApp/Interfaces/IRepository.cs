using System.Collections.Generic;

namespace RegisterDioApp.Interfaces
{
    public interface IRepository<T>
    {
         List<T> List();
         T ReturnById(int id);
         void Insert(T entidy);
         void Delete(int id);
         void Update(int id, T entidy);

         int NextId();
    }
}