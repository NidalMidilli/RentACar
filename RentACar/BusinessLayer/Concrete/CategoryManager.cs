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
    public class CategoryManager : ICategoryService
    {
        ICategoryDAL categorydal;
        public CategoryManager(ICategoryDAL categorydal)
        {
            this.categorydal = categorydal;
        }

        public int AddCategory(Category category)
        {
            return categorydal.Add(category);
        }

        public int DeleteCategory(Category category)
        {
            return categorydal.Delete(category);
        }

        public Category GetById(int id)
        {
            return categorydal.GetById(id);
        }

        public List<Category> ListAllCategories(Expression<Func<User, bool>> filter = null)
        {
            return categorydal.ListAll();
        }

        public int UpdateCategory(Category category)
        {
            return categorydal.Update(category);
        }
    }
}
