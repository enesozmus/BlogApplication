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
    public class AuthorManager : IAuthorService
    {
        #region constructor
        IAuthorDal _authorDal;

        public AuthorManager(IAuthorDal authorDal)
        {
            _authorDal = authorDal;
        }
        #endregion

        public void Add(Author author)
        {
            _authorDal.Insert(author);
        }

        public void Delete(Author parameter)
        {
            throw new NotImplementedException();
        }

        public List<Author> GetAll()
        {
            throw new NotImplementedException();
        }

        public Author GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Author parameter)
        {
            throw new NotImplementedException();
        }
    }
}
