using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.Tool
{
    public class EntityBase<T>
    {
        public EntityBase()
        {
            CreateTime = DateTime.Now;
        }
        public T Id { get; set; }
        public int IsDeleted { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
