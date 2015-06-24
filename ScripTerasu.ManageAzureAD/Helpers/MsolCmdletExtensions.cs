using ScripTerasu.ManageAzureAD.Framework.MSOnline.Administration.Automation;
using System.Management.Automation.Runspaces;
using System.Reflection;
using System.Runtime.Serialization;

namespace ScripTerasu.ManageAzureAD.Helpers
{
    public static class MsolCmdletExtensions
    {
        public static Command ToCommand(this IMsolCmdlet source)
        {
            if (source == null)
                return (Command)null;

            Command command = new Command(source.CommandText);

            PropertyInfo[] propertiesInfo = source.GetType().GetProperties();

            foreach (PropertyInfo propertyInfo in propertiesInfo)
            {
                if (propertyInfo.IsDefined(typeof(DataMemberAttribute)))
                {
                    var value = propertyInfo.GetValue(source);

                    if (value != null)
                    {
                        var defaultObject = TypeExtension.GetNewObject(propertyInfo.PropertyType);
                        if (!value.Equals(defaultObject))
                            command.Parameters.Add(propertyInfo.Name, value);
                    }
                }
            }

            return command;
        }
    }
}
