using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScripTerasu.ManageAzureAD.Model
{
    public class CredentialValidator : AbstractValidator<CredentialItem>
    {
        public CredentialValidator()
        {
            RuleFor(credential => credential.UserName).NotEmpty().EmailAddress().WithMessage("Please specify a UserName");
            RuleFor(credential => credential.Password).NotEmpty().WithMessage("Please specify a Password");
        }
    }
}