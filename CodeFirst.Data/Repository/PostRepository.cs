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
    ///   仓储操作层实现——Post
    /// </summary>
    public partial class PostRepository : RespositoryBase<Post>, IPostRepository
    { 
       public PostRepository(IDatabaseFactory databaseFactory)
            : base(databaseFactory)
            {

            } 
    }
}
