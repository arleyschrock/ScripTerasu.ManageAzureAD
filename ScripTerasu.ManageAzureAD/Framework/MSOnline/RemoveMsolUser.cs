using System;
using System.Management.Automation;

namespace ScripTerasu.ManageAzureAD.Framework.MSOnline
{
    /*
     * El cmdlet Remove-MsolUser se usa para quitar un usuario de Windows Azure Active Directory. 
     * Este cmdlet eliminará el usuario, sus licencias y cualquier otro tipo de datos asociados.
     */

    /// <summary>
    /// Quita un usuario de Windows Azure Active Directory.
    /// </summary>
    public class RemoveMsolUser : IMsolCmdlet
    {
        private const string _CommandText = "Remove-MsolUser";
        public string CommandText
        {
            get { return _CommandText; }
        }

        /// <summary>
        /// El identificador del usuario que se va a quitar.
        /// </summary>
        public string UserPrincipalName  { get; set; }

        /// <summary>
        /// Se usa para omitir la confirmación en pantalla.
        /// </summary>
        public SwitchParameter Force  { get; set; }

        /// <summary>
        /// El identificador de objeto del usuario que se va a quitar.
        /// </summary>
        public Guid ObjectId  { get; set; }

        /// <summary>
        /// Se usa para quitar de forma permanente un usuario eliminado de la papelera de reciclaje. 
        /// Esta operación, que solo se puede aplicar a usuarios eliminados, eliminará de forma permanente al usuario de Windows Azure Active Directory. 
        /// Una vez se ha completado esta operación, no podrá usar el comando Restore-MsolUser para recuperar el usuario.
        /// </summary>
        public SwitchParameter RemoveFromRecycleBin  { get; set; }

        /// <summary>
        /// El identificador único del inquilino en que se realizará la operación. 
        /// Si no se proporciona, se usará de forma predeterminada el valor del inquilino del usuario actual. 
        /// Este parámetro solamente es aplicable para usuarios asociados.
        /// </summary>
        public Guid TenantId  { get; set; }


    }
}
