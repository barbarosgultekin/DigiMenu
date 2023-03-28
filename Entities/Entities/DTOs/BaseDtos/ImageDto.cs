using Core.BaseEntity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities.DTOs.BaseDtos
{
    public class ImageDto : IDto
    {
        public string Path { get; set; }
        public int CategoryId { get; set; }
    }
}
