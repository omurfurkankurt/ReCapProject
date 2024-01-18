using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class UserManager : IUserService

    {
        IUserDal _userDal;

        public UserManager( IUserDal userDal)
        {
            _userDal = userDal;
        }

        public IResult Add(User user)
        {
           _userDal.Add(user);
            return new SuccessResult();
        }

        public IResult Delete(User user)
        {
           _userDal.Delete(user);
            return new SuccessResult();
        }

        public IResult Get(int id)
        {
            User user= _userDal.Get(p => p.Id == id);
            Console.WriteLine($"{user.Email},{user.FirstName},{user.LastName},{user.Password}");
            return new SuccessResult();
        }

        public IDataResult<List<User>> GetAll()
        {
          
            return new SuccessDataResult<List<User>>(_userDal.GetAll());
          
        }

        public IResult Update(User user)
        {
            _userDal.Update(user);
            return new SuccessResult();
        }
    }
}
