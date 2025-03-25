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

        public List<Message> GetListInbox(string mail)
        {
            return _messageDal.List(x => x.ReceiverMail == mail && x.MessageIsDelete==true);
        }

        public List<Message> GetListSendBox(string mail)
        {
            return _messageDal.List(x => x.SenderMail == mail && x.MessageIsDelete == true);
        }

        public List<Message> GetListTrashBox(string mail)
        {
            return _messageDal.List(x => x.ReceiverMail == mail && x.MessageIsDelete == false);
        }

        public int GetReadMessageCount(string mail)
        {
            return _messageDal.GetMessageCount(x => x.ReceiverMail == mail && x.MessageIsRead == false);
        }

        public int GetSentMessageCount(string mail)
        {
            return _messageDal.GetMessageCount(x => x.SenderMail == mail);
        }

        public int GetTrashMessageCount(string mail)
        {
            return _messageDal.GetMessageCount(x => x.ReceiverMail == mail && x.MessageIsDelete == false);
        }

        public void IsRead(int id, bool isRead)
        {
            var message = _messageDal.GetById(x => x.MessageId == id);
            if (message != null)
            {
                message.MessageIsRead = isRead;
                _messageDal.Update(message);
            }
        }

        public void MarkAsRead(List<int> messageIds)
        {
            _messageDal.MarkAsRead(messageIds);
        }

        public void MarkAsRemove(List<int> messageIds)
        {
            _messageDal.MarkAsRemove(messageIds);
        }

        public void MarkAsUnRead(List<int> messageIds)
        {
            _messageDal.MarkAsUnRead(messageIds);
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
            p.MessageIsRead = false;
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
