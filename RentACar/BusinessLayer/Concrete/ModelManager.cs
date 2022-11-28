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
    public class ModelManager : IModelService
    {
        IModelDAL modeldal;
        public ModelManager(IModelDAL modeldal)
        {
            this.modeldal = modeldal;
        }

        public int AddModel(Model model)
        {
            return modeldal.Add(model);
        }

        public int DeleteModel(Model model)
        {
            return modeldal.Delete(model);
        }

        public Model GetById(int id)
        {
            return modeldal.GetById(id);
        }

        public List<Model> ListAllModels(Expression<Func<User, bool>> filter = null)
        {
            return modeldal.ListAll();
        }

        public int UpdateModel(Model model)
        {
            return modeldal.Update(model);
        }
    }
}
