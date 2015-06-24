using ScripTerasu.ManageAzureAD.Framework.MSOnline.Administration.Automation;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Management.Automation;
using System.Management.Automation.Runspaces;

namespace ScripTerasu.ManageAzureAD.Helpers
{

    // Thank http://knicksmith.blogspot.com/2007/03/managing-exchange-2007-recipients-with.htm
    public sealed class MsolCmdletWrapper
    {
        #region Variable Declaration

        private InitialSessionState _initialSessionState;                           //InitialSessionState
        private Runspace _runspace;                                                 //Runspace
        private RunspaceInvoke _runspaceInvoke;                                     //RunspaceInvoke
        private ConnectMsolService _connectMsolService;

        private static readonly MsolCmdletWrapper instance =
            new MsolCmdletWrapper();                                   //Singleton instance


        #endregion

        #region Propierties 

        private bool _isConnect;

        public bool IsConnect
        {
            get { return _isConnect; }
            //set { _isConnect = value; }
        }
        

        #endregion Propierties

        private MsolCmdletWrapper() { }

        public static MsolCmdletWrapper Instance
        {
            get
            {
                return instance;
            }
        }

        #region Initialize

        private void InitializeInitialSessionState()
        {
            // Create Initial Session State for runspace.
            _initialSessionState = InitialSessionState.CreateDefault();
            _initialSessionState.ImportPSModule(new[] { "MSOnline" });
        }

        private void InitializeRunspace()
        {
            if (_initialSessionState == null)
                InitializeInitialSessionState();

            //Create and open runspace
            _runspace = RunspaceFactory.CreateRunspace(_initialSessionState);
            _runspace.Open();
        }

        private void InitializeRunspaceInvoke()
        {
            //Create runspace if it has not already been created
            if (_runspace == null)
                InitializeRunspace();

            //Create RunspaceInvoke
            _runspaceInvoke = new RunspaceInvoke(_runspace);
        }

        private void InitializeConnectMsolService()
        {
            // Create credential object.
            PSCredential credential = new PSCredential(UserCredential.UserName, UserCredential.Password);

            //Create RunspaceInvoke
            _connectMsolService = new ConnectMsolService() { Credential = credential };
        }

        #endregion Initialize

        #region RunspaceInvoke

        public ICollection<PSObject> RunspaceInvoke(string command)
        {
            //Create RunspaceInvoke if it has not already been created
            if (_runspaceInvoke == null)
                InitializeRunspaceInvoke();

            //Invoke the commmand and return the results
            return _runspaceInvoke.Invoke(command);
        }

        public ICollection<PSObject> RunspaceInvoke(string command, IEnumerable input)
        {
            //Create RunspaceInvoke if it has not already been created
            if (_runspaceInvoke == null)
                InitializeRunspaceInvoke();

            //Invoke the commmand and return the results
            return _runspaceInvoke.Invoke(command, input);
        }

        public ICollection<PSObject> RunspaceInvoke(string command, out IList errors)
        {
            //Invoke the RunspaceInvoke method with a null input
            return RunspaceInvoke(command, null, out errors);
        }

        public ICollection<PSObject> RunspaceInvoke(string command, IEnumerable input, out IList errors)
        {
            //Create RunspaceInvoke if it has not already been created
            if (_runspaceInvoke == null)
                InitializeRunspaceInvoke();

            //Invoke the commmand and return the results and errors
            return _runspaceInvoke.Invoke(command, input, out errors);
        }

        #endregion RunspaceInvoke

        #region PipelineInvoke
        public ICollection<PSObject> PipelineInvoke(Collection<Command> commands, out PipelineReader<object> Errors)
        {
            //Create Runspace if it has not already been created
            if (_runspace == null) { InitializeRunspace(); }

            ICollection<PSObject> results = null;
            Errors = null;

            if (IsConnect)
            {
                //Create Pipeline and add the commands
                Pipeline pipeline = _runspace.CreatePipeline();

                foreach (Command item in commands)
                {
                    pipeline.Commands.Add(item);
                }

                //Invoke the commands and return the results and errors
                results = pipeline.Invoke();
                Errors = pipeline.Error;
                pipeline = null;
                return results;
            }

            return null;
        }

        public ICollection<PSObject> PipelineInvoke(Collection<Command> commands)
        {
            //Create Runspace if it has not already been created
            if (_runspace == null)
                InitializeRunspace();

            if (IsConnect)
            {
                //Create Pipeline and add the commands
                Pipeline pipeline = _runspace.CreatePipeline();

                foreach (Command item in commands)
                {
                    pipeline.Commands.Add(item);
                }

                //Invoke the commands and return the results
                return pipeline.Invoke();
            }
            return null;
        }

        public ICollection<PSObject> PipelineInvoke(Command command, out PipelineReader<object> Errors)
        {
            //Create Runspace if it has not already been created
            if (_runspace == null)
                InitializeRunspace();

            //Create Pipeline and add the command
            Pipeline pipeline = _runspace.CreatePipeline();
            pipeline.Commands.Add(command);

            //Invoke the command and return the results and errors

            ICollection<PSObject> results = pipeline.Invoke();
            Errors = pipeline.Error;

            pipeline = null;

            return results;
        }

        public ICollection<PSObject> PipelineInvoke(Command command)
        {
            //Create Runspace if it has not already been created
            if (_runspace == null)
                InitializeRunspace();

            //Create Pipeline and add teh command
            Pipeline pipeline = _runspace.CreatePipeline();
            pipeline.Commands.Add(command);

            //Invoke the command and return the results
            return pipeline.Invoke();
        }

        public ICollection<PSObject> PipelineInvoke(Collection<IMsolCmdlet> commands, out PipelineReader<object> Errors)
        {
            //Create Runspace if it has not already been created
            if (_runspace == null) { InitializeRunspace(); }

            //Create Pipeline and add the commands
            Pipeline pipeline = _runspace.CreatePipeline();

            foreach (IMsolCmdlet item in commands)
            {
                pipeline.Commands.Add(MsolCmdletExtensions.ToCommand(item));
            }

            //Invoke the commands and return the results and errors
            ICollection<PSObject> results = pipeline.Invoke();
            Errors = pipeline.Error;
            pipeline = null;
            return results;
        }

        public ICollection<PSObject> PipelineInvoke(Collection<IMsolCmdlet> commands)
        {
            //Create Runspace if it has not already been created
            if (_runspace == null)
                InitializeRunspace();

            //Create Pipeline and add the commands
            Pipeline pipeline = _runspace.CreatePipeline();

            foreach (IMsolCmdlet item in commands)
            {
                pipeline.Commands.Add(MsolCmdletExtensions.ToCommand(item));
            }

            //Invoke the commands and return the results
            return pipeline.Invoke();
        }

        public ICollection<PSObject> PipelineInvoke(IMsolCmdlet command, out PipelineReader<object> Errors)
        {
            //Create Runspace if it has not already been created
            if (_runspace == null)
                InitializeRunspace();

            //Create Pipeline and add the command
            Pipeline pipeline = _runspace.CreatePipeline();
            pipeline.Commands.Add(MsolCmdletExtensions.ToCommand(command));

            //Invoke the command and return the results and errors

            ICollection<PSObject> results = pipeline.Invoke();
            Errors = pipeline.Error;

            pipeline = null;

            return results;
        }

        public ICollection<PSObject> PipelineInvoke(IMsolCmdlet command)
        {
            //Create Runspace if it has not already been created
            if (_runspace == null)
                InitializeRunspace();

            //Create Pipeline and add teh command
            Pipeline pipeline = _runspace.CreatePipeline();
            pipeline.Commands.Add(MsolCmdletExtensions.ToCommand(command));

            //Invoke the command and return the results
            return pipeline.Invoke();
        }

        #endregion

        public void Connect()
        {
            if (_runspace == null)
                InitializeRunspace();

            if (_connectMsolService == null)
                InitializeConnectMsolService();

            _isConnect = false;

            //Create Pipeline and add teh command
            Pipeline pipeline = _runspace.CreatePipeline();
            pipeline.Commands.Add(MsolCmdletExtensions.ToCommand(_connectMsolService));

            //Invoke the command and return the results
            //Invoke the commands and return the results and errors
            ICollection<PSObject> results = pipeline.Invoke();

            if (pipeline.Error.Count == 0)
            {
                _isConnect = true;
            }
        }

        public void Dispose()
        {
            //Close the Runspace and cleanup
            _runspace.Close();

            _runspaceInvoke = null;

            _runspace = null;
        }

    }
}