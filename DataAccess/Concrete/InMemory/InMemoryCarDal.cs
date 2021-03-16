using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars; //Bu bir global değişkendir. alt çizgi ifadesi ile beraber kullanılır.

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car {CarId=1,BrandId=1,ColorId=1,ModelYear=2017,DailyPrice=180,Description="En az 3 günlük kiralama gereklidir."},
                new Car {CarId=2,BrandId=1,ColorId=1,ModelYear=2019,DailyPrice=220,Description="En az 3 günlük kiralama gereklidir."},
                new Car {CarId=3,BrandId=2,ColorId=2,ModelYear=2015,DailyPrice=130,Description="En az 3 günlük kiralama gereklidir."},
                new Car {CarId=4,BrandId=3,ColorId=2,ModelYear=2016,DailyPrice=190,Description="En az 3 günlük kiralama gereklidir."},
                new Car {CarId=5,BrandId=3,ColorId=3,ModelYear=2018,DailyPrice=200,Description="En az 3 günlük kiralama gereklidir."},
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            _cars.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int id)
        {
            return _cars.Where(c => c.CarId == id).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    }
}
