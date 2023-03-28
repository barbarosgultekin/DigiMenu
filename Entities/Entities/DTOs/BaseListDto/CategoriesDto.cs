using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities.DTOs.BaseListDto
{
    public class CategoriesDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public string Allergy { get; set; }
        public string Description { get; set; }
        public string ParentCategory { get; set; }
    }
}
