using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IRepositoryDal<T>
    {
        T GetById(Expression<Func<T,bool>> filter);
        List<T> List();
        void Insert(T p);
        void Update(T p);
        void Remove(T p);
        List<T> List(Expression<Func<T, bool>> filter);
    }
}
