using DataAccess.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Mapping
{
    public class CategoryMap :IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.Property(category => category.Name).IsRequired().HasMaxLength(50);
            builder.Property(category => category.Allergy).HasMaxLength(200);
            builder.Property(category => category.Description).HasMaxLength(200);
        }

    }
}
