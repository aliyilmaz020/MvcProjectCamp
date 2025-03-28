﻿using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IAdminDal : IRepositoryDal<Admin>
    {
        bool IsLogin(Expression<Func<Admin, bool>> filter);
        string UserRole(Expression<Func<Admin, bool>> filter);
    }
}
