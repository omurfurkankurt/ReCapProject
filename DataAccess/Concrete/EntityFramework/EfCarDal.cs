using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore.Query.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, CarRentalDatabase>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (CarRentalDatabase carRentalDatabase = new CarRentalDatabase())
            {
                var result = from car in carRentalDatabase.Cars
                             join brand in carRentalDatabase.Brands on car.BrandId equals brand.BrandId
                             join color in carRentalDatabase.Colors on car.ColorId equals color.ColorId
                             select new CarDetailDto
                             {
                                 BrandId = brand.BrandId,
                                 BrandName = brand.BrandName,
                                 ColorName = color.ColorName,
                                 DailyPrice = car.DailyPrice
                             };

                return result.ToList();



            }
        }
    }
}
