using EntityLayer;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Validations
{
    public class ModelValidator:AbstractValidator<Model>
    {
        public ModelValidator()
        {
            RuleFor(x => x.modelName).NotEmpty().WithMessage("Model name cant be empty")
                                       .MinimumLength(3).WithMessage("Model name must be greater than 3")
                                       .MaximumLength(30).WithMessage("Model name must be less than 30");
        }
    }
}
