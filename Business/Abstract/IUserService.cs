using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IUserService 
    { 
        IResult Add(User user);
        IResult Update(User user);
        IResult Delete(User user);
        IResult Get(int id);
        IDataResult<List<User>> GetAll();
    }
}
