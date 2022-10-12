
using BusinessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        EfCategoryRepository _categoryRepository;

        public CategoryManager(EfCategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public void CategoryAdd(Category category)
        {
            _categoryRepository.Insert(category);
        }

        public void CategoryDelete(Category category)
        {
            _categoryRepository.Delete(category);
        }

        public void CategoryUpdate(Category category)
        {
            _categoryRepository.Update(category);
        }

        public Category GetById(int id)
        {
            return _categoryRepository.GetById(id);
        }

        public List<Category> GetList()
        {
            return _categoryRepository.GetAll();
        }
    }
}
