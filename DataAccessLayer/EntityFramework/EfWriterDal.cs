using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfWriterDal : GenericRepository<Writer>, IWriterDal
    {
        public string UserRole(Expression<Func<Writer, bool>> filter)
        {
            var user = _context.Set<Writer>().SingleOrDefault(filter);
            return user?.WriterRole ?? string.Empty;
        }
        public bool IsLogin(Expression<Func<Writer, bool>> filter)
        {
            return _context.Set<Writer>().Any(filter);
        }

        public Writer Operations(Expression<Func<Writer, bool>> filter)
        {
            return _context.Set<Writer>().SingleOrDefault(filter);
        }
    }
}
