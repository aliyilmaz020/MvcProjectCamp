using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class AboutManager : IAboutService
    {
        IAboutDal _aboutDal;

        public AboutManager(IAboutDal aboutDal)
        {
            _aboutDal = aboutDal;
        }

        public About TGetById(int id)
        {
            return _aboutDal.GetById(x => x.AboutId == id);
        }

        public List<About> TGetList()
        {
            return _aboutDal.List();
        }

        public void TInsert(About p)
        {
            _aboutDal.Insert(p);
        }

        public void TRemove(About p)
        {
            _aboutDal.Remove(p);
        }

        public void TUpdate(About p)
        {
            _aboutDal.Update(p);
        }
    }
}
