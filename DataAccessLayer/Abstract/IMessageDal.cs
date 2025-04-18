﻿using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IMessageDal : IRepositoryDal<Message>
    {
        int GetMessageCount(Expression<Func<Message,bool>> filter);
        void MarkAsRead(List<int> messageIds);
        void MarkAsUnRead(List<int> messageIds);
        void MarkAsRemove(List<int> messageIds);
        void MarkAsUndo(List<int> messageIds);
    }
}
