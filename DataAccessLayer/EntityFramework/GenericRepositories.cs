using DataAccessLayer.Abstract;
using System.Collections.Generic;
using System.Linq;
using DataAccessLayer.Context;
namespace DataAccessLayer.EntityFramework
{
    public class GenericRepositories<T> : IGenericDal<T> where T : class
    {
        public void Delete(T t)
        {
            using var c = new EFContext();
            c.Remove(t);
            c.SaveChanges();
        }

        public T GetByID(int id)
        {
            using var c = new EFContext();
            return c.Set<T>().Find(id);
        }

        public List<T> GetListAll()
        {
            using var c = new EFContext();
            return c.Set<T>().ToList();
        }

        public void Insert(T t)
        {
            using var c = new EFContext();
            c.Add(t);
            c.SaveChanges();
        }

        public void Update(T t)
        {
            using var c = new EFContext();
            c.Update(t);
            c.SaveChanges ();
        }
    }
}
