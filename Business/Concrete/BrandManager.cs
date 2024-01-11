using Business.Abstract;
using Business.Concrete;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public IResult Add(Brand brand)
        {
            if (brand.BrandName.Length < 2)
            {
                return new ErrorResult();

            }
            _brandDal.Add(brand);
            return new SuccessResult();
        }

        public IResult Delete(Brand brand)
        {
            _brandDal.Delete(brand);
            return new SuccessResult();
        }

        public IResult Get(int brandId)
        {

            Brand brand = _brandDal.Get(p => p.BrandId == brandId);
            Console.WriteLine($"Brand Id : {brand.BrandId}, Brand name :{brand.BrandName}");
            return new SuccessResult();

        }
        public IDataResult<List<Brand>> GetAll()
        {
            return new  SuccessDataResult<List<Brand>>(_brandDal.GetAll());
        }


        public IResult Update(Brand brand)
        {
            _brandDal.Update(brand);

            return new SuccessResult();
        }
    }
}
