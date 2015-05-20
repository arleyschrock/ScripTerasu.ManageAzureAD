using Microsoft.Online.Administration;
using System;
using System.Collections.Generic;

namespace ScripTerasu.ManageAzureAD.Framework.MSOnline
{
    /*
     * El cmdlet New-MsolUser se usa para crear un usuario nuevo en Windows Azure Active Directory. 
     * Para ofrecer al usuario acceso a los servicios, también deben tener asignada una licencia (mediante el parámetro LicenseAssignment).
     */

    /// <summary>
    /// Agrega un nuevo usuario a Windows Azure Active Directory.
    /// </summary>
    public class NewMsolUser : IMsolCmdlet
    {
        private const string _CommandText = "New-MsolUser";
        public string CommandText
        {
            get { return _CommandText; }
        }

        /// <summary>
        /// El identificador de este usuario. 
        /// Es obligatorio.
        /// </summary>
        public string UserPrincipalName  { get; set; }

        /// <summary>
        /// Las direcciones de correo electrónico alternativas del usuario.
        /// </summary>
        public List<string> AlternateEmailAddresses { get; set; }

        /// <summary>
        /// Si es verdadero, el usuario no podrá iniciar sesión con su identificador de usuario.
        /// </summary>
        public bool? BlockCredential { get; set; }

        /// <summary>
        /// La ciudad del usuario.
        /// </summary>
        public string City  { get; set; }

        /// <summary>
        /// El país del usuario.
        /// </summary>
        public string Country  { get; set; }

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
        /// Si es true, se obligará al usuario a cambiar su contraseña la próxima vez que inicie sesión.
        /// </summary>
        public bool? ForceChangePassword { get; set; }

        /// <summary>
        /// El identificador inmutable de la identidad federada del usuario. 
        /// Debe omitirse para usuarios con identidades estándares.
        /// </summary>
        public string ImmutableId  { get; set; }

        /// <summary>
        /// Los apellidos del usuario.
        /// </summary>
        public string LastName  { get; set; }

        /// <summary>
        /// Lista de licencias para asignarlas al usuario.
        /// </summary>
        public List<string> LicenseAssignment  { get; set; }

        /// <summary>
        /// Opciones de licencia para la asignación de licencias. 
        /// Se usan para deshabilitar de forma selectiva planes de servicio individuales en una SKU.
        /// </summary>
        //public List<LicenseOption> LicenseOptions  { get; set; }

        /// <summary>
        /// El número de teléfono móvil del usuario.
        /// </summary>
        public string MobilePhone  { get; set; }

        /// <summary>
        /// La oficina del usuario.
        /// </summary>
        public string Office  { get; set; }

        /// <summary>
        /// La nueva contraseña del usuario. Si el usuario está configurado para necesitar una contraseña segura, se deben cumplir las siguientes reglas:
        ///     - La contraseña debe contener una letra minúscula como mínimo.
        ///     - La contraseña debe contener una letra mayúscula como mínimo.
        ///     - La contraseña debe contener un carácter que no sea alfanumérico como mínimo.
        ///     - La contraseña no puede contener espacios, tabulaciones ni saltos de línea.
        ///     - La contraseña debe contener entre 8 y 16 caracteres.
        ///     - No se puede incluir el nombre de usuario en la contraseña.
        /// Si este valor se omite, se asignará una contraseña aleatoria al usuario.
        /// </summary>
        public string Password  { get; set; }

        /// <summary>
        /// Establece si la contraseña del usuario expira de forma periódica.
        /// </summary>
        public bool? PasswordNeverExpires { get; set; }

        /// <summary>
        /// El número de teléfono del usuario.
        /// </summary>
        public string PhoneNumber  { get; set; }

        /// <summary>
        /// El código postal del usuario.
        /// </summary>
        public string PostalCode  { get; set; }

        /// <summary>
        /// El idioma preferido del usuario.
        /// </summary>
        public string PreferredLanguage  { get; set; }

        /// <summary>
        /// El estado en que se encuentra el usuario.
        /// </summary>
        public string State  { get; set; }

        /// <summary>
        /// La dirección del usuario.
        /// </summary>
        public string StreetAddress  { get; set; }

        /// <summary>
        /// Establece si el usuario necesita una contraseña segura.
        /// </summary>
        public bool? StrongPasswordRequired  { get; set; }

        public Guid TenantId { get; set; }

        /// <summary>
        /// El cargo del usuario.
        /// </summary>
        public string Title  { get; set; }

        /// <summary>
        /// La ubicación del usuario en que se consumen los servicios. 
        /// Debe ser un código de país de dos letras.
        /// </summary>
        public string UsageLocation  { get; set; }
    }
}
