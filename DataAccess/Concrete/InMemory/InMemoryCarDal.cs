using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
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
                new Car{Id = 1, BrandId = 1, ColorId = 1, DailyPrice = 530, ModelYear = 2022},
                new Car{Id = 2, BrandId = 3, ColorId = 2, DailyPrice = 840, ModelYear = 2021},
                new Car{Id = 3, BrandId = 2, ColorId = 2, DailyPrice = 360, ModelYear = 2023},
                new Car{Id = 4, BrandId = 4, ColorId = 5, DailyPrice = 650, ModelYear = 2022},
                new Car{Id = 5, BrandId = 7, ColorId = 3, DailyPrice = 578, ModelYear = 2021},
                new Car{Id = 6, BrandId = 3, ColorId = 6, DailyPrice = 850, ModelYear = 2023}

            };

        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
           Car carToDelete = _cars.SingleOrDefault(p=>p.Id == car.Id);


        }

        public List<Car> GetAll()
        {
           return _cars;
        }

        public List<Car> GetById(int carId)
        {
          return _cars.Where(p=>p.BrandId == carId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(p=> p.Id == car.Id);
            carToUpdate.DailyPrice= car.DailyPrice;
            carToUpdate.ModelYear= car.ModelYear;
            carToUpdate.BrandId= car.BrandId;
            carToUpdate.ColorId= car.ColorId;

            
        }
    }
}
