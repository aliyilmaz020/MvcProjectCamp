using DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.Repositories
{
    public class GenericRepository<T> : IRepositoryDal<T> where T : class
    {
        protected readonly Context _context = new Context();
        private readonly DbSet<T> _object;
        public GenericRepository()
        {
            _object = _context.Set<T>();
        }

        public T GetById(Expression<Func<T, bool>> filter)
        {
            return _object.SingleOrDefault(filter);
        }

        public void Insert(T p)
        {
            var addEntity = _context.Entry(p);
            addEntity.State = EntityState.Added;
            _context.SaveChanges();
        }

        public List<T> List()
        {
            return _object.ToList();
        }

        public List<T> List(Expression<Func<T, bool>> filter)
        {
            return _object.Where(filter).ToList();
        }

        public void Remove(T p)
        {
            var removeEntity = _context.Entry(p);
            removeEntity.State = EntityState.Deleted;
            _context.SaveChanges();
        }

        public void Update(T p)
        {
            var updateEntity = _context.Entry(p);
            updateEntity.State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
