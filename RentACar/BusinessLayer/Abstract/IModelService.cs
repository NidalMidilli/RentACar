using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IModelService
    {
        public int AddModel(Model model);

        public int UpdateModel(Model model);

        public int DeleteModel(Model model);

        List<Model> ListAllModels(Expression<Func<User, bool>> filter = null);

        Model GetById(int id);
    }
}
