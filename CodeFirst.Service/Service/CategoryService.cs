//------------------------------------------------------------------------------
//
//		代码作者：吴培德
//		生成时间：2017-10-10 09:50
//------------------------------------------------------------------------------

using CodeFirst.Data.Infrastructure;
using CodeFirst.Data.Repositories.IRepository;
using CodeFirst.Domain;
using CodeFirst.Service.IService;
using System.Collections.Generic;



namespace CodeFirst.Service.Service
{
	/// <summary>
    ///   服务层、应用层实现——Category
    /// </summary>
    public partial class CategoryService : ICategoryService
    { 
       private readonly ICategoryRepository CategoryRepository;
        private readonly IUnitOfWork unitOfWork;
        public CategoryService(ICategoryRepository CategoryRepository, IUnitOfWork unitOfWork)
        {
            this.CategoryRepository = CategoryRepository;
            this.unitOfWork = unitOfWork;
        }  
        #region ICategoryService Members

        public IEnumerable<Category> GetCategoryList()
        {
            var Category = CategoryRepository.GetAll();
            return Category;
        }

        public Category GetCategory(int id)
        {
            var Category = CategoryRepository.GetById(id);
            return Category;
        }

        public void CreateCategory(Category Category)
        {
            CategoryRepository.Add(Category);
            SaveCategory();
        }

        public void DeleteCategory(int id)
        {
            var Category = CategoryRepository.GetById(id);
            CategoryRepository.Delete(Category);
            SaveCategory();
        }

        public void SaveCategory()
        {
            unitOfWork.Commit();
        }

        #endregion

    }
}
