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
        private readonly IAdminDal _dal;
        public RoleManager(IAdminDal dal)
        {
            _dal = dal;
        }

        public string UserRole(string username)
        {
            return _dal.UserRole(x => x.AdminUserName == username);
        }
    }
}
