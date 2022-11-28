using DataAccess.Abstract;
using EntityLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.Repositories
{
    public class CarDAL : Repository<Car>, ICarDAL
    {
        Context con = new Context();
      
        public List<Car> GetCarWithModels(Expression<Func<User, bool>> filter = null)
        {
            return con.Cars.Include(x => x.Model).ToList();
        }
    }
}
