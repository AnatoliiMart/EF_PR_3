using System.Collections.Generic;

namespace EF_PR_3.Models
{
    interface IRepository<T>
    {
        int Create(T obj);
        int Delete(T obj);
        int Update(T obj);
        List<T> GetAll();
        T GetById(int id);
        List<T> GetBySurname(string searchingSurname);
    }
}
