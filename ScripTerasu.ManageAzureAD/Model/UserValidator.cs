using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScripTerasu.ManageAzureAD.Model
{
    public class UserValidator  : AbstractValidator<UserItem>
    {
        public UserValidator()
        {
            RuleFor(user => user.UserPrincipalName).NotEmpty().EmailAddress().WithMessage("Please specify a UserName");
            RuleFor(user => user.DisplayName).NotEmpty().WithMessage("Please specify a Password");
        }
    }
}
