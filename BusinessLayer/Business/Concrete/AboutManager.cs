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
    public class AboutManager : IAboutService
    {
        #region constructor
        IAboutDal _aboutDal;

        public AboutManager(IAboutDal aboutDal)
        {
            _aboutDal = aboutDal;
        }
        #endregion

        public void Add(About parameter)
        {
            throw new NotImplementedException();
        }

        public void Delete(About parameter)
        {
            throw new NotImplementedException();
        }

        public List<About> GetAll()
        {
            return _aboutDal.GetAll();
        }

        public About GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(About parameter)
        {
            throw new NotImplementedException();
        }
    }
}
