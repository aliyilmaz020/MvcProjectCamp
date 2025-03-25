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
    public class EfMessageDal : GenericRepository<Message>, IMessageDal
    {
        public int GetMessageCount(Expression<Func<Message, bool>> filter)
        {
            return _context.Set<Message>().Where(filter).Count();
        }

        public void MarkAsRead(List<int> messageIds)
        {
            var messages = _context.Set<Message>().Where(x => messageIds.Contains(x.MessageId)).ToList();
            foreach (var message in messages)
            {
                message.MessageIsRead = true;
            }
            _context.SaveChanges();
        }

        public void MarkAsRemove(List<int> messageIds)
        {
            var messages = _context.Set<Message>().Where(x=>messageIds.Contains(x.MessageId)).ToList();
            foreach(var message in messages)
            {
                message.MessageIsDelete = false;
            }
            _context.SaveChanges();
        }

        public void MarkAsUnRead(List<int> messageIds)
        {
            var messages = _context.Set<Message>().Where(x => messageIds.Contains(x.MessageId)).ToList();
            foreach (var message in messages)
            {
                message.MessageIsRead = false;
            }
            _context.SaveChanges();
        }
        
    }
}
