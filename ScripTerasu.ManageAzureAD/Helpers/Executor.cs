using ScripTerasu.ManageAzureAD.Framework.MSOnline;
using ScripTerasu.ManageAzureAD.Framework.MSOnline.Administration.Automation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Management.Automation;
using System.Management.Automation.Runspaces;

namespace ScripTerasu.ManageAzureAD.Helpers
{
    /// <summary>
    /// Description of Executor
    /// </summary>
    public sealed class Executor
    {
        private static Executor instance = new Executor();

        public static Executor Instance
        {
            get
            {
                return instance;
            }
        }

        private Executor()
        {
        }



        public Collection<PSObject> ExcutePowershellCommands(InitialSessionState initialSession, List<IMsolCmdlet> collCmdlets)
        {
            try
            {
                Collection<PSObject> collPSObject = null;
                
                List<Command> collCommand = new List<Command>();
                foreach (var itemCmdlets in collCmdlets)
                {
                    collCommand.Add(MsolCmdletExtensions.ToCommand(itemCmdlets));
                }
                
                using (Runspace psRunSpace = RunspaceFactory.CreateRunspace(initialSession))
                {
                    // Open runspace.
                    psRunSpace.Open();

                    //Iterate through each command and executes it.
                    foreach (var itemCommand in collCommand)
                    {
                        var pipe = psRunSpace.CreatePipeline();
                        pipe.Commands.Add(itemCommand);
                        // Execute command and generate results and errors (if any).
                        Collection<PSObject> results = pipe.Invoke();

                        Collection<object> error = pipe.Error.ReadToEnd();
                        if (error.Count > 0)
                        {
                            return null;
                        }
                        else
                        {
                            collPSObject = results;
                        }
                    }
                    // Close the runspace.
                    psRunSpace.Close();
                }
                return collPSObject;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Collection<PSObject> ExcutePowershellCommandsMSOnline(List<IMsolCmdlet> collCmdlets)
        {
            try
            {
                // Create Initial Session State for runspace.
                InitialSessionState initialSession = InitialSessionState.CreateDefault();
                initialSession.ImportPSModule(new[] { "MSOnline" });

                // Create credential object.
                PSCredential credential = new PSCredential(UserCredential.UserName, UserCredential.Password);

                collCmdlets.Insert(0, new ConnectMsolService() { Credential = credential });

                return this.ExcutePowershellCommands(initialSession, collCmdlets);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
