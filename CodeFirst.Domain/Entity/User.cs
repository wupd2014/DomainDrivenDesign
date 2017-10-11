using CodeFirst.Tool;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.Domain
{
    public class User : EntityBase<int>
    {

        //[Key]
        //public int UserId { get; set; }
        [Required(ErrorMessage = "账号必填")]
        [MaxLength(100)]
        [Display(Name = "账号")]
        public string Account { get; set; }
        [Required(ErrorMessage = "密码必填")]
        [MaxLength(128)]
        [Display(Name = "密码")]
        public byte[] PassWordHash { get; set; }

        [Display(Name = "Email")]
        public string Email { get; set; }

        [Display(Name = "账号状态")]
        public bool IsActived { get; set; }

        [Display(Name = "联系电话")]
        public string TelNo { get; set; }

        [Display(Name = "创建时间")]
        public DateTime CreateTime { get; set; }

        [Display(Name = "上一次登录时间")]
        public DateTime LastLoginTime { get; set; }

        public ICollection<Role> Roles { get; set; }
    }
}
