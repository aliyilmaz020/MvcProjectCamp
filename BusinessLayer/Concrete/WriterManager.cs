﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class WriterManager : IWriterService
    {
        IWriterDal _writerDal;

        public WriterManager(IWriterDal writerDal)
        {
            _writerDal = writerDal;
        }

        public void TInsert(Writer p)
        {
            _writerDal.Insert(p);
        }

        public Writer TGetById(int id)
        {
            return _writerDal.GetById(x => x.WriterId == id);
        }

        public List<Writer> TGetList()
        {
            return _writerDal.List();
        }

        public void TRemove(Writer p)
        {
            _writerDal.Remove(p);
        }

        public void TUpdate(Writer p)
        {
            _writerDal.Update(p);
        }
    }
}
