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
    public class ContactManager : IContactService
    {
        IContactDal _contactDal;
        public ContactManager(IContactDal contactDal)
        {
            _contactDal = contactDal;
        }

        public Contact TGetById(int id)
        {
            return _contactDal.GetById(x=>x.ContactId==id);
        }

        public List<Contact> TGetList()
        {
            return _contactDal.List();
        }

        public void TInsert(Contact p)
        {
            _contactDal.Insert(p);
        }

        public void TRemove(Contact p)
        {
            _contactDal.Remove(p);
        }

        public void TUpdate(Contact p)
        {
            _contactDal.Update(p);
        }
    }
}
