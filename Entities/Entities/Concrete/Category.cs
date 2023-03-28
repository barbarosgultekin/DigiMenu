using Core.BaseEntity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities.Concrete
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string? Allergy { get; set; }
        public string? Description { get; set; }

        public int ParentCategoryId { get; set; }
        public Category? ParentCategory { get; set; }

        public ICollection<Category> ChildCategories { get; set; }
    }
}
