using Core.BaseEntity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities.DTOs.BaseDtos
{
    public class CategoryDto : IDto
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string Allergy { get; set; }
        public string Description { get; set; }
        public int ParentCategoryId { get; set; }
    }
}
