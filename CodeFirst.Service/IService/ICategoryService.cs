//------------------------------------------------------------------------------
//
//		代码作者：吴培德
//		生成时间：2017-10-10 09:50
//------------------------------------------------------------------------------

using CodeFirst.Domain;
using System;
using System.Collections.Generic;


namespace  CodeFirst.Service.IService
{
	/// <summary>
    ///   服务层、应用层接口——Category
    /// </summary>
    public partial interface ICategoryService 
    {
        IEnumerable<Category> GetCategoryList();
        Category GetCategory(int id);
        void CreateCategory(Category Category);
        void DeleteCategory(int id);
        void SaveCategory();
    }
}
