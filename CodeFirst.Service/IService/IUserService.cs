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
    ///   服务层、应用层接口——User
    /// </summary>
    public partial interface IUserService 
    {
        IEnumerable<User> GetUserList();
        User GetUser(int id);
        void CreateUser(User User);
        void DeleteUser(int id);
        void SaveUser();
    }
}
