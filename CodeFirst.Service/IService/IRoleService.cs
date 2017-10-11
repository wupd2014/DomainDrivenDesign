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
    ///   服务层、应用层接口——Role
    /// </summary>
    public partial interface IRoleService 
    {
        IEnumerable<Role> GetRoleList();
        Role GetRole(int id);
        void CreateRole(Role Role);
        void DeleteRole(int id);
        void SaveRole();
    }
}
