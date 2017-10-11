using CodeFirst.Tool;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace CodeFirst.Domain
{
    public class Post:EntityBase<int>
    {
        //public int PostId { get; set; }
        [Required(ErrorMessage = "文章名称必填")]
        [MaxLength(100, ErrorMessage = "最大长度为100个字符")]
        public string PostName { get; set; }
        [Required(ErrorMessage = "发布日期必填")]
        public DateTime CreateTime { get; set; }
        [Required(ErrorMessage = "文章内容必填")]
        public string Content { get; set; }
        [Required]
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}
