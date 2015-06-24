using FluentValidation;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScripTerasu.ManageAzureAD.Model
{
    public abstract class ModelBase
    {
        private IValidator _Validator;

        public IValidator Validator
        {
            get { return _Validator; }
            set { _Validator = value; }
        }
        public bool IsValid
        {
            get
            {
                return Validator.Validate(this).IsValid;
            }
        }

        public IList<ValidationFailure> ValidationErrors
        {
            get
            {
                return Validator.Validate(this).Errors;
            }
        }

    }
}
