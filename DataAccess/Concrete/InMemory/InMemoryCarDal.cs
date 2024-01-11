using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;


        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{CarId = 1, BrandId = 1, ColorId = 1, DailyPrice = 530, ModelYear = 2022},
                new Car{CarId = 2, BrandId = 3, ColorId = 2, DailyPrice = 840, ModelYear = 2021},
                new Car{CarId = 3, BrandId = 2, ColorId = 2, DailyPrice = 360, ModelYear = 2023},
                new Car{CarId = 4, BrandId = 4, ColorId = 5, DailyPrice = 650, ModelYear = 2022},
                new Car{CarId = 5, BrandId = 7, ColorId = 3, DailyPrice = 578, ModelYear = 2021},
                new Car{CarId = 6, BrandId = 3, ColorId = 6, DailyPrice = 850, ModelYear = 2023}

            };

        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
           Car carToDelete = _cars.SingleOrDefault(p=>p.CarId == car.CarId);


        }

        public List<Car> GetAll()
        {
           return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            return _cars;
        }

        public List<Car> GetById(int carId)
        {
          return _cars.Where(p=>p.BrandId == carId).ToList();
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(p=> p.CarId == car.CarId);
            carToUpdate.DailyPrice= car.DailyPrice;
            carToUpdate.ModelYear= car.ModelYear;
            carToUpdate.BrandId= car.BrandId;
            carToUpdate.ColorId= car.ColorId;

            
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }
    }
}
