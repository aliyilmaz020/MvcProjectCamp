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
    public class MessageManager : IMessageService
    {
        IMessageDal _messageDal;

        public MessageManager(IMessageDal messageDal)
        {
            _messageDal = messageDal;
        }

        public List<Message> GetListInbox()
        {
            return _messageDal.List(x => x.ReceiverMail == "admin@manager.com");
        }

        public List<Message> GetListSendBox()
        {
            return _messageDal.List(x => x.SenderMail == "admin@manager.com");
        }

        public Message TGetById(int id)
        {
            return _messageDal.GetById(x => x.MessageId == id);
        }

        public List<Message> TGetList()
        {
            return _messageDal.List();
        }

        public void TInsert(Message p)
        {
            _messageDal.Insert(p);
        }

        public void TRemove(Message p)
        {
            _messageDal.Remove(p);
        }

        public void TUpdate(Message p)
        {
            _messageDal.Update(p);
        }
    }
}
