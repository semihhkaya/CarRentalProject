using Business.Concrete;
using Business.Constants;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //UserManager userManager = new UserManager(new EfUserDal());
            //var result = new User { FirstName = "45xz", LastName = "xzcx", Email = "gfcv", Password = "zxccz" };
            //userManager.Add(result);

            //var result2 = new Customer {UserId=2, CompanyName="Xamxz"};
            //CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            //customerManager.Add(result2);

            //ColorManager colorManager = new ColorManager(new EfColorDal());
            //var result3 = new Color {ColorName="Mavi"};
            //colorManager.Add(result3);

            //BrandManager brandManager = new BrandManager(new EfBrandDal());
            //var result4 = new Brand {BrandName="Honda"};
            //brandManager.Add(result4);

            //CarManager carManager = new CarManager(new EfCarDal());
            //var result5 = new Car {BrandId=1,ColorId=2,CarName="Honda CRV",DailyPrice=278,Description="CarX",ModelYear=2020};
            //carManager.Add(result5);

            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            var result6 = new Rental { CarId = 1, CustomerId = 1};
            rentalManager.Add(result6);
        }
    }
}
