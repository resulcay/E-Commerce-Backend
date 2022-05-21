using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(p => p.ProductName).NotEmpty();
            RuleFor(p => p.ProductName).MinimumLength(2);
            RuleFor(p => p.UnitPrice).NotEmpty();
            RuleFor(p => p.UnitPrice).GreaterThanOrEqualTo(0);
            RuleFor(p => p.UnitPrice).GreaterThanOrEqualTo(10).When(p => p.CategoryId == 1);
            //   RuleFor(p => p.ProductName).Must(StartWithA);
            //RuleFor(p => p.UnitsInStock).Must(MaximumStock);
        }

        //private bool MaximumStock(short value)
        //{
        //    return value <= 10;
        //}

        private bool StartWithA(string arg)
        {
            return arg.StartsWith("A");
        }
    }
}
