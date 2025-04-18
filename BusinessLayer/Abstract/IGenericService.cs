﻿using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IGenericService<T> where T : class
    {
        List<T> TGetList();
        void TInsert(T p);
        T TGetById(int id);
        void TRemove(T p);
        void TUpdate(T p);
    }
}
