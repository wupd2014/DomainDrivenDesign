//------------------------------------------------------------------------------
//		代码作者：吴培德
//		生成时间：2017-10-10 16:30
//------------------------------------------------------------------------------

using CodeFirst.Domain;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.ModelConfiguration.Configuration;


namespace CodeFirst.Data.Configurations
{
    /// <summary>
    /// 实体类-数据表映射——User
    /// </summary>    
	internal partial class UserConfiguration : EntityTypeConfiguration<User>
    {
        /// <summary>
        /// 实体类-数据表映射构造函数——User
        /// </summary>
        public UserConfiguration()
        {
            ToTable("User");
            HasKey(m => m.Id);

			UserConfigurationAppend();
        }
		
        /// <summary>
        /// 额外的数据映射
        /// </summary>
        partial void UserConfigurationAppend();
		
        /// <summary>
        /// 将当前实体映射对象注册到当前数据访问上下文实体映射配置注册器中
        /// </summary>
        /// <param name="configurations">实体映射配置注册器</param>
        public void RegistTo(ConfigurationRegistrar configurations)
        {
            configurations.Add(this);
        }
    }
}
