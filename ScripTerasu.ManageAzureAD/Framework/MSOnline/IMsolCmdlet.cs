using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation.Runspaces;
using System.Text;
using System.Threading.Tasks;

namespace ScripTerasu.ManageAzureAD.Framework.MSOnline
{
    public interface IMsolCmdlet
    {
        string CommandText { get; }
    }
}
