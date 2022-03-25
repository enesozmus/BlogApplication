using BusinessLayer.Business.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Business.Concrete
{
    public class BlogManager : IBlogService
    {
        #region constructor
        IBlogDal _blogDal;

        public BlogManager(IBlogDal blogDal)
        {
            _blogDal = blogDal;
        }
        #endregion

        public void Add(Blog parameter)
        {
            throw new NotImplementedException();
        }

        public void Delete(Blog parameter)
        {
            throw new NotImplementedException();
        }

        public void Update(Blog parameter)
        {
            throw new NotImplementedException();
        }

        public List<Blog> GetAll()
        {
            return _blogDal.GetAll();
        }

        public Blog GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Blog> GetLastThreeBlogs()
        {
            return _blogDal.GetAll().Take(3).ToList();
        }

        public List<Blog> GetBlogById(int id)
        {
            return _blogDal.GetAll(x => x.BlogID == id);
        }

        public List<Blog> GetBlogListByAuthor(int id)
        {
            return _blogDal.GetAll(x => x.AuthorID == id);
        }

        public List<Blog> GetBlogListWithCategory()
        {
            return _blogDal.GetListWithCategory();
        }
    }
}
