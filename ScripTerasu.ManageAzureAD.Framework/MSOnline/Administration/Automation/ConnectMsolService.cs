using System.Management.Automation;
using System.Runtime.Serialization;

namespace ScripTerasu.ManageAzureAD.Framework.MSOnline.Administration.Automation
{
    /* 
     * El cmdlet Connect-MsolService intentará iniciar una conexión con Windows Azure Active Directory.   
     * El autor de la llamada debe proporcionar su credencial (un objeto PSCredential), o especificar el conmutador CurrentCredentials para usar las credenciales del usuario con sesión iniciada.
     * Este cmdlet puede devolver una advertencia o un error si la versión del módulo que está en uso ha expirado.
     */

    /// <summary>
    /// Inicia una conexión con Windows Azure Active Directory.
    /// </summary>
    [DataContract]
    public class ConnectMsolService : IMsolCmdlet
    {
        private const string _CommandText = "Connect-MsolService";

        /// <summary>
        /// La credencial que se usará para conectar con Windows Azure Active Directory.
        /// </summary>
        [DataMember]
        public PSCredential Credential { get; set; }

        /// <summary>
        /// Si se especifica, usa las credenciales del usuario con sesión iniciada para conectar con Windows Azure Active Directory.
        /// <para>Esto no requiere que el usuario especifique sus credenciales explícitamente.</para>
        /// </summary>
        [DataMember]
        public SwitchParameter CurrentCredential { get; set; }

        public string CommandText
        {
            get { return _CommandText; }
        }
    }
}
