﻿using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IWriterDal : IRepositoryDal<Writer>
    {
        string UserRole(Expression<Func<Writer, bool>> filter);
        bool IsLogin(Expression<Func<Writer, bool>> filter);
        Writer Operations(Expression<Func<Writer, bool>> filter);
    }
}
