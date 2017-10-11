using CodeFirst.Tool;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.Domain
{
    public class Category : EntityBase<int>
    {
        // public int CategoryId { get; set; }
        [Required(ErrorMessage = "目录名称必填")]
        [StringLength(25, ErrorMessage = "最大长度不超过25个字符")]
        [MaxLength(50)]
        public string CategoryName { get; set; }

        public string CategoryDesc { get; set; }
        public virtual ICollection<Post> Post { get; set; }

    }
}
