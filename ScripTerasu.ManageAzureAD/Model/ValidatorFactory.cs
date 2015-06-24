using FluentValidation;
using GalaSoft.MvvmLight.Ioc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScripTerasu.ManageAzureAD.Model
{
    public class ValidatorFactory : ValidatorFactoryBase
    {
        public ValidatorFactory()
        {
            //register the Validators
            SimpleIoc.Default.Register<IValidator<CredentialItem>, CredentialValidator>();
        }

        public override IValidator CreateInstance(Type validatorType)
        {
            return SimpleIoc.Default.GetInstance(validatorType) as IValidator;
        }
    }
}
