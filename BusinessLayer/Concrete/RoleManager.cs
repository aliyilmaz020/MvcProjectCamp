using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class RoleManager : IRoleService
    {
        private readonly IAdminDal _adminDal;
        private readonly IWriterDal _writerDal;
        public RoleManager(IAdminDal adminDal, IWriterDal writerDal)
        {
            _adminDal = adminDal;
            _writerDal = writerDal;
        }

        public string AdminRole(string username)
        {
            return _adminDal.AdminRole(x => x.AdminUserName == username);
        }

        public string UserRole(string username)
        {
            return _writerDal.UserRole(x=>x.WriterMail == username);
        }
    }
}
