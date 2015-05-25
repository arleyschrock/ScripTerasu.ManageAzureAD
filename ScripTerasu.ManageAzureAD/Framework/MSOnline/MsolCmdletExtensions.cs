using ScripTerasu.ManageAzureAD.Helpers;
using System.Management.Automation.Runspaces;

namespace ScripTerasu.ManageAzureAD.Framework.MSOnline
{
    public static class MsolCmdletExtensions
    {
        public static Command ToCommand(this IMsolCmdlet source)
        {
            if (source == null)
                return (Command)null;

            var srtCommandText = source.CommandText;
            Command command = new Command(srtCommandText);
            foreach (var prop in source.GetType().GetProperties())
            {
                var value = prop.GetValue(source);
                if (value != null && value.ToString() != srtCommandText)
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
