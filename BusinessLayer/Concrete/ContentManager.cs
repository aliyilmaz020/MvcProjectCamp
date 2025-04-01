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
    public class ContentManager : IContentService
    {
        IContentDal _contentDal;
        public ContentManager(IContentDal contentDal)
        {
            _contentDal = contentDal;
        }

        public void TInsert(Content p)
        {
            _contentDal.Insert(p);
        }

        public Content TGetById(int id)
        {
            return _contentDal.GetById(x => x.ContentId == id);
        }

        public List<Content> TGetList()
        {
            return _contentDal.List();
        }

        public void TRemove(Content p)
        {
            _contentDal.Remove(p);
        }

        public void TUpdate(Content p)
        {
            _contentDal.Update(p);
        }

        public List<Content> GetListByHeadingId(int id)
        {
            return _contentDal.List(x => x.HeadingId == id);
        }

        public List<Content> GetListByWriter(string mail)
        {
            return _contentDal.List(x => x.Writer.WriterMail == mail);
        }
    }
}
