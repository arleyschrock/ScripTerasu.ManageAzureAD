using ScripTerasu.ManageAzureAD.Framework.MSOnline;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Management.Automation.Runspaces;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ScripTerasu.ManageAzureAD.Framework
{
    public static class MsolCmdletExtensions
    {
        public static Command ToCommand(this IMsolCmdlet source)
        {
            if (source == null)
                return (Command)null;

            string srtCommandText = source.CommandText;
            Command command = new Command(srtCommandText);
            foreach (var prop in source.GetType().GetProperties())
            {
                var value = prop.GetValue(source);
                if (value != null && value != srtCommandText)
                {
                    var defaultObject = TypeExtension.GetNewObject(prop.PropertyType);
                    if (!value.Equals(defaultObject))
                        command.Parameters.Add(prop.Name, value);
                }
            }

            return command;
        }
    }
}
