using System;
using System.Management.Automation;

namespace ScripTerasu.ManageAzureAD.Framework.MSOnline
{
    /*
     * Restaura un usuario de la vista Usuarios eliminados a su estado original. 
     * Los usuarios permanecerán en la vista Usuarios eliminados durante 30 días.
     */

    /// <summary>
    /// Restaura un usuario de la vista Usuarios eliminados a su estado original.
    /// </summary>
    public class RestoreMsolUser : IMsolCmdlet
    {
        private const string _CommandText = "Connect-MsolService";
        public string CommandText
        {
            get { return _CommandText; }
        }

        /// <summary>
        /// El identificador del usuario que se va a restaurar.
        /// </summary>
        public string UserPrincipalName  { get; set; }

        /// <summary>
        /// Si se configura, las direcciones proxy que causan conflictos se quitarán del usuario. 
        /// Este parámetro debe usarse si otro usuario activo también usa una o más direcciones proxy del usuario.
        /// </summary>
        public SwitchParameter AutoReconcileProxyConflicts  { get; set; }

        /// <summary>
        /// El UserPrincipalName que se va a usar al restaurar el usuario. 
        /// Debería usarse si otro usuario activo usa el UserPrincipalName original del usuario.
        /// </summary>
        public string NewUserPrincipalName { get; set; }

        /// <summary>
        /// El ObjectId del usuario que se va a restaurar.
        /// </summary>
        public Guid ObjectId  { get; set; }
    }
}
