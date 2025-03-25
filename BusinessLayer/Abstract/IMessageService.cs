using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IMessageService : IGenericService<Message>
    {
        List<Message> GetListInbox(string mail);
        List<Message> GetListSendBox(string mail);
        void IsRead(int id, bool isRead);
        int GetReadMessageCount(string mail);
        int GetSentMessageCount(string mail);
        void MarkAsRead(List<int> messageIds);
        void MarkAsUnRead(List<int> messageIds);
    }
}
