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
    public class HeadingManager : IHeadingService
    {
        private readonly IHeadingDal _headingDal;

        public HeadingManager(IHeadingDal headingDal)
        {
            _headingDal = headingDal;
        }

        public void TAdd(Heading p)
        {
            _headingDal.Insert(p);
        }

        public Heading TGetById(int id)
        {
            return _headingDal.GetById(x=>x.HeadingId == id);
        }

        public List<Heading> TGetList()
        {
            return _headingDal.List();
        }

        public void TRemove(Heading p)
        {
            _headingDal.Remove(p);
        }

        public void TUpdate(Heading p)
        {
            _headingDal.Update(p);
        }
    }
}
