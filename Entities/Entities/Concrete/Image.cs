using Core.BaseEntity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities.Concrete
{
    public class Image : BaseEntity
    {
        public string Path { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }

    }
}
