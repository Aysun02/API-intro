using Businness.DTOs.Category.Request;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businness.Validators.Category
{
    internal class CategoryCreateDTOValidator : AbstractValidator<CategoryCreateDTO>
    {

        public CategoryCreateDTOValidator()
        {
            RuleFor(x => x.Title)
                .MinimumLength(3)
                .WithMessage("Title's length must be minimum 3 item");
        }
    }
}
