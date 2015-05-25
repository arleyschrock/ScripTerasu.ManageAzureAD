using System;
using System.Collections.Generic;

namespace ScripTerasu.ManageAzureAD.Framework.MSOnline
{
    /*
     * El cmdlet Set-MsolUser se usa para actualizar un objeto de usuario. 
     * Tenga en cuenta que este cmdlet debe usarse solamente para las propiedades básicas. 
     * Las licencias, la contraseña y el nombre principal de usuario pueden actualizarse mediante los 
     * cmdlets Set-MsolUserLicense, Set-MsolUserPassword y Set-MsolUserPrincipalName, respectivamente.
     */

    /// <summary>
    /// Actualiza un usuario de Windows Azure Active Directory.
    /// </summary>
    public class SetMsolUser : IMsolCmdlet
    {
        private const string _CommandText = "Set-MsolUser";
        public string CommandText
        {
            get { return _CommandText; }
        }

        /// <summary>
        /// Direcciones de correo electrónico alternativas del usuario.
        /// </summary>
        public List<string> AlternateEmailAddresses  { get; set; }

        /// <summary>
        /// Alternar números de teléfono móvil del usuario.
        /// </summary>
        public List<string> AlternateMobilePhones { get; set; }

        /// <summary>
        /// Si es verdadero, el usuario no podrá iniciar sesión con su identificador de usuario.
        /// </summary>
        public bool? BlockCredential  { get; set; }

        /// <summary>
        /// La ciudad del usuario.
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// El país o región del usuario.
        /// </summary>
        public string Country { get; set; }

        /// <summary>
        /// El departamento del usuario.
        /// </summary>
        public string Department { get; set; }

        /// <summary>
        /// El nombre para mostrar del usuario.
        /// </summary>
        public string DisplayName { get; set; }

        /// <summary>
        /// El número de fax del usuario.
        /// </summary>
        public string Fax { get; set; }

        /// <summary>
        /// El nombre del usuario.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// El identificador inmutable de la identidad federada del usuario. 
        /// Debe omitirse para usuarios con identidades estándares.
        /// </summary>
        public string ImmutableId { get; set; }

        /// <summary>
        /// Los apellidos del usuario.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// El número de teléfono móvil del usuario.
        /// </summary>
        public string MobilePhone { get; set; }

        /// <summary>
        /// El identificador único del usuario.
        /// </summary>
        public Guid ObjectId { get; set; }

        /// <summary>
        /// La ubicación de la oficina del usuario.
        /// </summary>
        public string Office  { get; set; }

        /// <summary>
        /// Establece si la contraseña del usuario expira de forma periódica.
        /// </summary>
        public bool? PasswordNeverExpires { get; set; }

        /// <summary>
        /// El número de teléfono del usuario.
        /// </summary>
        public string PhoneNumber  { get; set; }

        /// <summary>
        /// El código postal de la ubicación del usuario.
        /// </summary>
        public string PostalCode { get; set; }

        /// <summary>
        /// El idioma preferido del usuario.
        /// </summary>
        public string PreferredLanguage { get; set; }

        /// <summary>
        /// El estado o provincia en que se encuentra el usuario.
        /// </summary>
        public string State  { get; set; }

        /// <summary>
        /// La dirección del usuario.
        /// </summary>
        public string StreetAddress { get; set; }

        //public StrongAuthenticationRequirement StrongAuthenticationRequirements  { get; set; }

        /// <summary>
        /// Establece si el usuario necesita una contraseña segura.
        /// </summary>
        public bool? StrongPasswordRequired  { get; set; }
    }
}
