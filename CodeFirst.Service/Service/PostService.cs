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
    ///   服务层、应用层实现——Post
    /// </summary>
    public partial class PostService : IPostService
    { 
       private readonly IPostRepository PostRepository;
        private readonly IUnitOfWork unitOfWork;
        public PostService(IPostRepository PostRepository, IUnitOfWork unitOfWork)
        {
            this.PostRepository = PostRepository;
            this.unitOfWork = unitOfWork;
        }  
        #region IPostService Members

        public IEnumerable<Post> GetPostList()
        {
            var Post = PostRepository.GetAll();
            return Post;
        }

        public Post GetPost(int id)
        {
            var Post = PostRepository.GetById(id);
            return Post;
        }

        public void CreatePost(Post Post)
        {
            PostRepository.Add(Post);
            SavePost();
        }

        public void DeletePost(int id)
        {
            var Post = PostRepository.GetById(id);
            PostRepository.Delete(Post);
            SavePost();
        }

        public void SavePost()
        {
            unitOfWork.Commit();
        }

        #endregion

    }
}
