using BusinessLayer.Abstract;
using DataAccess.Abstract;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CarManager : ICarService
    {
        ICarDAL cardal;
        public CarManager(ICarDAL cardal)
        {
            this.cardal = cardal;
        }

        public int AddCar(Car car)
        {
            return cardal.Add(car);
        }

        public int DeleteCar(Car car)
        {
            return cardal.Delete(car);
        }

        public Car GetById(int id)
        {
            return cardal.GetById(id);
        }

        public List<Car> GetCarWithModels(Expression<Func<User, bool>> filter = null)
        {
            return cardal.GetCarWithModels();
        }

        public List<Car> ListAllCars(Expression<Func<User, bool>> filter = null)
        {
            return cardal.ListAll();
        }

        public int UpdateCar(Car car)
        {
            return cardal.Update(car);
        }
    }
}
