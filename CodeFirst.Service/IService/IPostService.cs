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
    ///   服务层、应用层接口——Post
    /// </summary>
    public partial interface IPostService 
    {
        IEnumerable<Post> GetPostList();
        Post GetPost(int id);
        void CreatePost(Post Post);
        void DeletePost(int id);
        void SavePost();
    }
}
