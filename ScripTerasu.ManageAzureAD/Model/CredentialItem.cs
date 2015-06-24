using FluentValidation;
using ScripTerasu.ManageAzureAD.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScripTerasu.ManageAzureAD.Model
{
    public class CredentialItem : ModelBase
    {
        public string UserName { get; set; }

        public string Password { get; set; }
        
    }
}
