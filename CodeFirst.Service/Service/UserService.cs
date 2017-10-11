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
    ///   服务层、应用层实现——User
    /// </summary>
    public partial class UserService : IUserService
    {
        private readonly IUserRepository UserRepository;
        private readonly IUnitOfWork unitOfWork;
        public UserService(IUserRepository UserRepository, IUnitOfWork unitOfWork)
        {
            this.UserRepository = UserRepository;
            this.unitOfWork = unitOfWork;
        }
        #region IUserService Members

        public IEnumerable<User> GetUserList()
        {
            var User = UserRepository.GetAll();
            return User;
        }

        public User GetUser(int id)
        {
            var User = UserRepository.GetById(id);
            return User;
        }

        public void CreateUser(User User)
        {
            UserRepository.Add(User);
            SaveUser();
        }

        public void DeleteUser(int id)
        {
            var User = UserRepository.GetById(id);
            UserRepository.Delete(User);
            SaveUser();
        }

        public void SaveUser()
        {
            unitOfWork.Commit();
        }

        #endregion

    }
}
