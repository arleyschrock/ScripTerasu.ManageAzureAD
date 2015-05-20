using System;

namespace ScripTerasu.ManageAzureAD.Framework.MSOnline
{
    /*
     * El cmdlet Convert-MsolFederatedUser se usa para actualizar un usuario en un dominio que se convirtió recientemente de inicio de sesión único (también conocido como federación de identidades) en el tipo de autenticación estándar. 
     * Se debe proporcionar una contraseña nueva para el usuario.
     */

    /// <summary>
    /// Actualiza un usuario de un dominio que se convirtió recientemente de inicio de sesión único (también conocido como federación de identidades) en el tipo de autenticación estándar.
    /// </summary>
    public class ConvertMsolFederatedUser : IMsolCmdlet
    {
        private const string _CommandText = "Convert-MsolFederatedUser";
        public string CommandText
        {
            get { return _CommandText; }
        }

        /// <summary>
        /// La nueva contraseña del usuario.
        /// </summary>
        public string NewPassword  { get; set; }

        /// <summary>
        /// El identificador único del inquilino en que se realizará la operación. 
        /// Si no se proporciona, se usará de forma predeterminada el valor del inquilino del usuario actual. 
        /// Este parámetro solamente es aplicable para usuarios asociados.
        /// </summary>
        public Guid TenantId  { get; set; }

        /// <summary>
        /// El UserID de Windows Azure Active Directory del usuario que se va a convertir.
        /// </summary>
        public string UserPrincipalName { get; set; }
    }
}
