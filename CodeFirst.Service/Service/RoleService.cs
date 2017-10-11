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
    ///   服务层、应用层实现——Role
    /// </summary>
    public partial class RoleService : IRoleService
    { 
       private readonly IRoleRepository RoleRepository;
        private readonly IUnitOfWork unitOfWork;
        public RoleService(IRoleRepository RoleRepository, IUnitOfWork unitOfWork)
        {
            this.RoleRepository = RoleRepository;
            this.unitOfWork = unitOfWork;
        }  
        #region IRoleService Members

        public IEnumerable<Role> GetRoleList()
        {
            var Role = RoleRepository.GetAll();
            return Role;
        }

        public Role GetRole(int id)
        {
            var Role = RoleRepository.GetById(id);
            return Role;
        }

        public void CreateRole(Role Role)
        {
            RoleRepository.Add(Role);
            SaveRole();
        }

        public void DeleteRole(int id)
        {
            var Role = RoleRepository.GetById(id);
            RoleRepository.Delete(Role);
            SaveRole();
        }

        public void SaveRole()
        {
            unitOfWork.Commit();
        }

        #endregion

    }
}
