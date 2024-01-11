using Business.Concrete;
using Core.DataAccess;
using Core.DataAccess.EntityFramework;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System.Net.Http.Headers;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            //CarAddTest(carManager);

            //  CarUpdateTest(carManager);


            // CarDeleteTest(carManager);

            //CarGetTest(carManager);

            //CarGetAllTest(carManager);

            //Console.WriteLine("/////////");
            //GetCarsByBrandIdTest(carManager);
            //Console.WriteLine("////////////");
            //GetCarsByColorIdTest(carManager);

            BrandManager brandManager = new BrandManager(new EfBrandDal());
            //BrandAddtest(brandManager);


            //BrandUpdateTest(brandManager);

            //BrandDeleteTest(brandManager);

            //BrandGetTest(brandManager);


            //BrandGetAllTest(brandManager);

            ColorManger colorManger = new ColorManger(new EfColorDal());

            //ColorAddTest(colorManger);

            //ColorDeleteTest(colorManger);

            //ColorUpdateTest(colorManger);



            //ColorGetTest(colorManger);

            //ColorGetAllTest(colorManger);


            //GetCarDetailTest(carManager);

            static void CarAddTest(CarManager carManager)
            {
                carManager.Add(new Car { BrandId = 1, ColorId = 3, DailyPrice = 1500, ModelYear = 2003, Description = "2003 Green BMW" });
                carManager.Add(new Car { BrandId = 6, ColorId = 1, DailyPrice = 2000, ModelYear = 1998, Description = "1998 Red Citroen" });
                carManager.Add(new Car { BrandId = 10, ColorId = 22, DailyPrice = 1700, ModelYear = 2011, Description = "2011 Salmon Porsche" });
                carManager.Add(new Car { BrandId = 5, ColorId = 5, DailyPrice = 1000, ModelYear = 2018, Description = "2018 Purple Renault" });
                carManager.Add(new Car { BrandId = 13, ColorId = 9, DailyPrice = 2300, ModelYear = 2013, Description = "2013 Black Ford" });
                carManager.Add(new Car { BrandId = 11, ColorId = 10, DailyPrice = 1750, ModelYear = 2020, Description = "2020 White Tesla" });
                carManager.Add(new Car { BrandId = 19, ColorId = 1, DailyPrice = 2300, ModelYear = 2011, Description = "2011 Red Chevrolet" });
                carManager.Add(new Car { BrandId = 1, ColorId = 9, DailyPrice = 1700, ModelYear = 2019, Description = "2019 Black BMW" });
                carManager.Add(new Car { BrandId = 15, ColorId = 23, DailyPrice = 1000, ModelYear = 2015, Description = "2015 Crimson Honda" });
                carManager.Add(new Car { BrandId = 8, ColorId = 10, DailyPrice = 900, ModelYear = 2011, Description = "2011 White Fiat" });
                carManager.Add(new Car { BrandId = 7, ColorId = 15, DailyPrice = 1300, ModelYear = 2015, Description = "2015 Sky Blue Peugeot" });
                carManager.Add(new Car { BrandId = 9, ColorId = 4, DailyPrice = 1700, ModelYear = 2019, Description = "2019 Yellow Volvo" });
            }
        }

        private static void GetCarDetailTest(CarManager carManager)
        {
            var result = carManager.GetCarDetails();
            if (result.Success == true)
            {

                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.BrandId + " // " + car.BrandName + " // " + car.ColorName + " // " + car.DailyPrice);
                }

            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void ColorGetAllTest(ColorManger colorManger)
        {
            foreach (var color in colorManger.GetAll().Data)
            {
                Console.WriteLine("{0} {1} ", color.ColorId, color.ColorName);

            }
        }

        private static void ColorGetTest(ColorManger colorManger)
        {
            colorManger.Get(2);
        }

        private static void ColorUpdateTest(ColorManger colorManger)
        {
            colorManger.Update(new Color { ColorId = 2, ColorName = "Kırmızı" });
        }

        private static void ColorDeleteTest(ColorManger colorManger)
        {
            colorManger.Delete(new Color { ColorId = 1 });
        }

        private static void ColorAddTest(ColorManger colorManger)
        {
            colorManger.Add(new Color { ColorName = "Red" });
            colorManger.Add(new Color { ColorName = "Red" });
            colorManger.Add(new Color { ColorName = "Blue" });
            colorManger.Add(new Color { ColorName = "Green" });
            colorManger.Add(new Color { ColorName = "Yellow" });
            colorManger.Add(new Color { ColorName = "Purple" });
            colorManger.Add(new Color { ColorName = "Pink" });
            colorManger.Add(new Color { ColorName = "Orange" });
            colorManger.Add(new Color { ColorName = "Brown" });
            colorManger.Add(new Color { ColorName = "Black" });
            colorManger.Add(new Color { ColorName = "White" });
            colorManger.Add(new Color { ColorName = "Gray" });
            colorManger.Add(new Color { ColorName = "Gold" });
            colorManger.Add(new Color { ColorName = "Silver" });
            colorManger.Add(new Color { ColorName = "Navy Blue" });
            colorManger.Add(new Color { ColorName = "Sky Blue" });
            colorManger.Add(new Color { ColorName = "Lime Green" });
            colorManger.Add(new Color { ColorName = "Teal" });
            colorManger.Add(new Color { ColorName = "İndigo" });
            colorManger.Add(new Color { ColorName = "Magenta" });
            colorManger.Add(new Color { ColorName = "Violet" });
            colorManger.Add(new Color { ColorName = "Khaki" });
            colorManger.Add(new Color { ColorName = "Salmon" });
            colorManger.Add(new Color { ColorName = "Crimson" });
            colorManger.Add(new Color { ColorName = "Lavender" });
            colorManger.Add(new Color { ColorName = "Plum" });
            colorManger.Add(new Color { ColorName = "Blue Violet" });
            colorManger.Add(new Color { ColorName = "Olive" });
            colorManger.Add(new Color { ColorName = "Cyan" });
            colorManger.Add(new Color { ColorName = "Maroon" });
            colorManger.Add(new Color { ColorName = "Beige" });
        }

        private static void BrandGetAllTest(BrandManager brandManager)
        {
            foreach (var brand in brandManager.GetAll().Data)
            {

                Console.WriteLine("{0} {1}", brand.BrandId, brand.BrandName);

            }
        }

        private static void BrandGetTest(BrandManager brandManager)
        {
            brandManager.Get(20);
        }

        private static void BrandDeleteTest(BrandManager brandManager)
        {
            brandManager.Delete(new Brand { BrandId = 21 });
        }

        private static void BrandUpdateTest(BrandManager brandManager)
        {
            brandManager.Update(new Brand { BrandId = 20, BrandName = " TOG" });
        }

        private static void BrandAddtest(BrandManager brandManager)
        {
            brandManager.Add(new Brand { BrandName = "BMW" });
            brandManager.Add(new Brand { BrandName = "Audi" });
            brandManager.Add(new Brand { BrandName = "Mercedes" });
            brandManager.Add(new Brand { BrandName = "Volkswagen" });
            brandManager.Add(new Brand { BrandName = "Renault" });
            brandManager.Add(new Brand { BrandName = "Citroen" });
            brandManager.Add(new Brand { BrandName = "Peugeot" });
            brandManager.Add(new Brand { BrandName = "Fiat" });
            brandManager.Add(new Brand { BrandName = "Volvo" });
            brandManager.Add(new Brand { BrandName = "Porsche" });
            brandManager.Add(new Brand { BrandName = "Tesla" });
            brandManager.Add(new Brand { BrandName = "Toyota" });
            brandManager.Add(new Brand { BrandName = "Ford" });
            brandManager.Add(new Brand { BrandName = "Nissan" });
            brandManager.Add(new Brand { BrandName = "Honda" });
            brandManager.Add(new Brand { BrandName = "Lotus" });
            brandManager.Add(new Brand { BrandName = "Subaru" });
            brandManager.Add(new Brand { BrandName = "Bentley" });
            brandManager.Add(new Brand { BrandName = "Chevrolet" });
            brandManager.Add(new Brand { BrandName = "Koenigsegg" });
        }

        private static void GetCarsByColorIdTest(CarManager carManager)
        {
            foreach (var carr in carManager.GetCarsByColorId(2).Data)
            {
                Console.WriteLine("Id:{0}   Car: {1}     Color: {2}   Details: {3}    Daily Price: {4}", carr.CarId, carr.BrandId, carr.ColorId, carr.Description, carr.DailyPrice);
            }
        }

        private static void GetCarsByBrandIdTest(CarManager carManager)
        {
            foreach (var carr in carManager.GetCarsByBrandId(4).Data)
            {
                Console.WriteLine("Id:{0}   Car: {1}     Color: {2}   Details: {3}    Daily Price: {4}", carr.CarId, carr.BrandId, carr.ColorId, carr.Description, carr.DailyPrice);
            }
        }

        private static void CarGetAllTest(CarManager carManager)
        {
            foreach (var carr in carManager.GetAll().Data)
            {
                Console.WriteLine("Id:{0}   Car: {1}     Color: {2}   Details: {3}    Daily Price: {4}", carr.CarId, carr.BrandId, carr.ColorId, carr.Description, carr.DailyPrice);


            }
        }

        private static void CarGetTest(CarManager carManager)
        {
            carManager.Get(17);
        }

        private static void CarDeleteTest(CarManager carManager)
        {
            carManager.Delete(new Car { CarId = 12 });
        }

        private static void CarUpdateTest(CarManager carManager)
        {
            carManager.Update(new Car { CarId = 20, BrandId = 10, ColorId = 2, DailyPrice = 450, Description = " Mersedes", ModelYear = 2020 });
        }
    }
}
//var car = new Car { BrandId = 1, ColorId = 1, DailyPrice = 150, Description = "HONDA", ModelYear = 2021 };
//var car2 = new Car { BrandId = 4, ColorId = 3, DailyPrice = 200, Description = "BMW", ModelYear = 2023 };


//carManager.Delete(new Car { Id = 2});
//carManager.Update(new Car { Id = 8 , ColorId = 2, BrandId =2,DailyPrice=200 , Description= "Reno ", ModelYear = 2024});

//carManager.GetById(1);

//CarManager carManager = new CarManager(new EfCarDal());

//var car = new Car { BrandId = 1, ColorId = 1, DailyPrice = 150, Description = "HONDA", ModelYear = 2021 };
//var car2 = new Car { BrandId = 4, ColorId = 3, DailyPrice = 200, Description = "BMW", ModelYear = 2023 };






//List<Car> cars = carManager.GetAll();
//foreach (var car1 in cars)
//{
//    Console.WriteLine("{0} {1} {2} {3} {4} {5}", car1.Id, car1.BrandId, car1.ModelYear, car1.Description, car1.DailyPrice, car1.ColorId);

//}
