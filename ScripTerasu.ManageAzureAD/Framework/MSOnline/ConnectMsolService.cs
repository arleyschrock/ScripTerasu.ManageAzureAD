using System.Management.Automation;

namespace ScripTerasu.ManageAzureAD.Framework.MSOnline
{
    /* 
     * El cmdlet Connect-MsolService intentará iniciar una conexión con Windows Azure Active Directory.   
     * El autor de la llamada debe proporcionar su credencial (un objeto PSCredential), o especificar el conmutador CurrentCredentials para usar las credenciales del usuario con sesión iniciada.
     * Este cmdlet puede devolver una advertencia o un error si la versión del módulo que está en uso ha expirado.
     */

    /// <summary>
    /// Inicia una conexión con Windows Azure Active Directory.
    /// </summary>
    public class ConnectMsolService : IMsolCmdlet
    {
        private const string _CommandText = "Connect-MsolService";
        public string CommandText
        {
            get { return _CommandText; }
        }

        /// <summary>
        /// La credencial que se usará para conectar con Windows Azure Active Directory.
        /// </summary>
        public PSCredential Credential { get; set; }

        /// <summary>
        /// Si se especifica, usa las credenciales del usuario con sesión iniciada para conectar con Windows Azure Active Directory.  
        /// Esto no requiere que el usuario especifique sus credenciales explícitamente.
        /// </summary>
        public SwitchParameter CurrentCredentials { get; set; }
    }
}
