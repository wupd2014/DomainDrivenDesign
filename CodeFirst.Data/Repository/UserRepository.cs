//------------------------------------------------------------------------------
//		代码作者：吴培德
//		生成时间：2017-10-10 16:30
//------------------------------------------------------------------------------

using CodeFirst.Domain;
using CodeFirst.Data.Infrastructure;
using CodeFirst.Data.Repositories.IRepository;


namespace  CodeFirst.Data.Repositories.Repository
{
	/// <summary>
    ///   仓储操作层实现——User
    /// </summary>
    public partial class UserRepository : RespositoryBase<User>, IUserRepository
    { 
       public UserRepository(IDatabaseFactory databaseFactory)
            : base(databaseFactory)
            {

            } 
    }
}
