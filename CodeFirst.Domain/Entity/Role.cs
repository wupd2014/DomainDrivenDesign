using CodeFirst.Tool;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace CodeFirst.Domain
{
    public class Role:EntityBase<int>
    {
        //[Key]
        //public int RoleId { get; set; }

        [Required(ErrorMessage = "角色名称必填")]
        [Display(Name = "角色名称")]
        [MaxLength(100, ErrorMessage = "最大长度不超过100个字符")]
        public string Name { get; set; }

        [Display(Name = "角色备注")]
        [MaxLength(200, ErrorMessage = "备注最大长度200个字符")]
        public string Desc { get; set; }

        [Required]
        [Display(Name = "角色状态")]
        public bool IsActived { get; set; }

        public ICollection<User> Users { get; set; }
    }
}
