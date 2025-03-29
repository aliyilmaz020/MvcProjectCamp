using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BCrypt.Net;

namespace BusinessLayer.Concrete
{
    public class AdminManager : IAdminService
    {
        private readonly IAdminDal _adminDal;

        public AdminManager(IAdminDal adminDal)
        {
            _adminDal = adminDal;
        }

        public bool TIsLogin(string username, string password)
        {
            return _adminDal.IsLogin(x => x.AdminUserName == username && x.AdminPassword == password);
        }

        public Admin TGetById(int id)
        {
            return _adminDal.GetById(x => x.AdminId == id);
        }

        public List<Admin> TGetList()
        {
            return _adminDal.List();
        }

        public void TInsert(Admin p)
        {
            _adminDal.Insert(p);
        }

        public void TRemove(Admin p)
        {
            _adminDal.Remove(p);
        }

        public void TUpdate(Admin p)
        {
            _adminDal.Update(p);
        }
    }
}
