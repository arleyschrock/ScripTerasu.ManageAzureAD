using Microsoft.Online.Administration.Automation;
using System;
using System.Collections.ObjectModel;
using System.Management.Automation;
using System.Management.Automation.Runspaces;
using System.Security;

namespace ScripTerasu.PowerShell
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


        /// <summary>
        /// Execute Get-MsolAccountSku command and returns resulted data.
        /// </summary>
        /// <returns></returns>
        public Collection<PSObject> ExcutePowershellCommands()
        {
            // Assign username to variable.
            string UserName = "salmendra@tyschile.cl";

            // Create and assign secure password string.
            SecureString securePass = new SecureString();
            foreach (char secureChar in "JDhNO5wv")
            {
                securePass.AppendChar(secureChar);
            }

            //Password = securePass;

            try
            {
                Collection<PSObject> licenseList = null;
                // Create Initial Session State for runspace.
                InitialSessionState initialSession = InitialSessionState.CreateDefault();
                initialSession.ImportPSModule(new[] { "MSOnline" });
                // Create credential object.
                PSCredential credential = new PSCredential(UserName, securePass);
                // Create command to connect office 365.
                Command connectCommand = new Command("Connect-MsolService");
                connectCommand.Parameters.Add((new CommandParameter("Credential", credential)));
                // Create command to get office 365 users.

                //CmdletsHelper CmdletsHelper = new CmdletsHelper();
                GetAccountSku GetAccountSku = new GetAccountSku();
                GetAccountSku.TenantId = new Guid();
                //GetAccountSku.
                Command command = new Command( GetAccountSku.ToString());

                using (Runspace psRunSpace = RunspaceFactory.CreateRunspace(initialSession))
                {
                    // Open runspace.
                    psRunSpace.Open();

                    //Iterate through each command and executes it.
                    foreach (var com in new Command[] { connectCommand })
                    {
                        var pipe = psRunSpace.CreatePipeline();
                        pipe.Commands.Add(com);

                        // Execute command and generate results and errors (if any).
                        Collection<PSObject> results = pipe.Invoke();
                        var error = pipe.Error.ReadToEnd();
                        if (error.Count > 0 && com == connectCommand)
                        {
                            //MessageBox.Show(error[0].ToString(), "Problem in login");
                            //this.Close();
                            return null;
                        }
                        if (error.Count > 0 && com == command)
                        {
                            //MessageBox.Show(error[0].ToString(), "Problem in getting licenses");
                            //this.Close();
                            return null;
                        }
                        else
                        {
                            licenseList = results;
                        }
                    }
                    // Close the runspace.
                    psRunSpace.Close();
                }
                return licenseList;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
