using DataAccess.Entities.DTOs.BaseDtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class ImageValidator:AbstractValidator<ImageDto>
    {
        public ImageValidator()
        {
            RuleFor(i => i.Path).MinimumLength(10);
        }
    }
}
