using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IRepository<T>
    {
        //T Get(int id);
        List<T> List();
        void Insert(T p);
        void Update(T p);
        void Remove(T p);
        List<T> List(Expression<Func<T, bool>> filter);
    }
}
