using Business.Abstract;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CustomerManger : ICustomerService
    {
        ICustomerDal _customerDal;

        public CustomerManger(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }
      
       
        public IResult Add(Customer customer)
        {
            _customerDal.Add(customer);
            return new SuccessResult();

        }

        public IResult Delete(Customer customer)
        {
            _customerDal.Delete(customer);
            return new SuccessResult();
        }

        public IResult Get(int id)
        {
            Customer customer = _customerDal.Get(p => p.UserId == id);
            Console.WriteLine($"{customer.UserId},{customer.CompanyName}");
            return new SuccessResult();
        }

        public IDataResult<List<Customer>> GetAll()
        {
            
            return new SuccessDataResult<List<Customer>>(_customerDal.GetAll());
        }

        public IResult Update(Customer customer)
        {
            _customerDal.Update(customer);
            return new SuccessResult();
        }
    }
}
