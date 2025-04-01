using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfAdminDal : GenericRepository<Admin>, IAdminDal
    {
        public bool IsLogin(Expression<Func<Admin, bool>> filter)
        {
            return _context.Set<Admin>().Any(filter);
        }

        public string AdminRole(Expression<Func<Admin, bool>> filter)
        {
            var admin = _context.Set<Admin>().SingleOrDefault(filter);
            return admin?.AdminRole ?? string.Empty;
        }

    }
}
