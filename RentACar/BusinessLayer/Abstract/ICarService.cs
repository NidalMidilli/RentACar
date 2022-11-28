using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ICarService
    {
        public int AddCar(Car car);
        public int UpdateCar(Car car);

        public int DeleteCar(Car car);

        List<Car> ListAllCars(Expression<Func<User, bool>> filter = null);

        List<Car> GetCarWithModels(Expression<Func<User, bool>> filter = null);
        Car GetById(int id);


    }
}
