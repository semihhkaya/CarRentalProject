using Business.Concrete;
using DataAccess.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.DailyPrice);
            }

            CarManager carManager2 = new CarManager(new InMemoryCarDal());

            foreach (var carId in carManager2.GetById())
            {
                Console.WriteLine(carId.DailyPrice + " 1.Arabanın Günlük Fiyatını Yazdırır");
            }
        }
    }
}
