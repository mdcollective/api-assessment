using FluentValidation;
using System.Collections.Generic;
using Interview.Model.Types;

namespace Interview.Validators
{
    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(customer => customer.FirstName).NotNull().NotEmpty();
            RuleFor(customer => customer.LastName).NotNull().NotEmpty();
            RuleFor(customer => customer.Gender).NotNull().NotEmpty();
            RuleFor(customer => customer.Age).GreaterThan(18); //must be an adult
        }
    }

    public class CustomerListValidator : AbstractValidator<List<Customer>>
    {
        public CustomerListValidator()
        {
            RuleForEach(x => x).SetValidator(new CustomerValidator());
        }
    }
}
