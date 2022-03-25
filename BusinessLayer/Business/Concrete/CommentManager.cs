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
    public class CommentManager : ICommentService
    {
        ICommentDal _commentDal;

        public CommentManager(ICommentDal commentDal    )
        {
            _commentDal = commentDal;
        }

        public void Add(Comment comment)
        {
            _commentDal.Insert(comment);
        }

        public void Delete(Comment parameter)
        {
            throw new NotImplementedException();
        }

        public List<Comment> GetAll()
        {
            throw new NotImplementedException();
        }

        public Comment GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Comment parameter)
        {
            throw new NotImplementedException();
        }
        public List<Comment> GetAllComments(int id)
        {
            return _commentDal.GetAll(x => x.BlogID == id);
        }
    }
}
