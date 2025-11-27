using FluentValidation;
using Inventra.Entities;

namespace Inventra.WebApp.Validators
{
    public class InventoryValidator: AbstractValidator<Inventory>
    {
        public InventoryValidator()
        {
            RuleFor(i => i.InventoryName)
                .NotEmpty().WithMessage("Inventory name is required.")
                .MaximumLength(100).WithMessage("Inventory name cannot exceed 100 characters.");
        }
    }
}
