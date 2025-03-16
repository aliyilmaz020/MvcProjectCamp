using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.Repositories
{
    public class CategoryRepository : ICategoryDal
    {
        Context c = new Context();
        DbSet<Category> _object;

        public Category Get(int id)
        {
            return _object.Find(id);
        }

        public void Insert(Category p)
        {
            _object.Add(p);
            c.SaveChanges();
        }

        public List<Category> List()
        {
           return _object.ToList();
        }

        public void Remove(Category p)
        {
            _object.Remove(p);
            c.SaveChanges();
        }

        public void Update(Category p)
        {
            c.SaveChanges();
        }
    }
}
