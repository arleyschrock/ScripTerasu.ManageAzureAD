using System;
using System.Management.Automation;

namespace ScripTerasu.ManageAzureAD.Framework.MSOnline
{
    /*
     * El cmdlet Get-MsolUser puede usarse para recuperar un usuario individual o una lista de usuarios. 
     * Se recuperará un usuario individual si se usa el parámetro ObjectId o UserPrincipalName.    
     */

    /// <summary>
    /// Recupera un usuario de Windows Azure Active Directory.
    /// </summary>
    public class GetMsolUser : IMsolCmdlet
    {
        private const string _CommandText = "Get-MsolUser";
        public string CommandText
        {
            get { return _CommandText; }
        }

        /// <summary>
        /// Si se encuentra, se devolverán todos los resultados. 
        /// No se puede usar con el parámetro MaxResults.
        /// </summary>
        public SwitchParameter All { get; set; }

        /// <summary>
        /// La ciudad por la que se filtran los resultados.
        /// </summary>
        public string City  { get; set; }

        /// <summary>
        /// El país por el que se filtran los resultados.
        /// </summary>
        public string Country  { get; set; }
        
        /// <summary>
        /// El departamento por el que se filtran los resultados.
        /// </summary>
        public string Department { get; set; }

        /// <summary>
        /// El dominio por el que se filtran los resultados. 
        /// Debe tratarse de un dominio comprobado para la compañía. 
        /// Se devolverán todos los usuarios que tengan una dirección de correo electrónico (principal o secundaria) en este dominio.
        /// </summary>
        public string DomainName  { get; set; }

        /// <summary>
        /// El filtro para usuarios habilitados (o deshabilitados). 
        /// Los posibles valores son All, EnabledOnly y DisabledOnly.
        /// </summary>
        public string EnabledFilter  { get; set; }

        /// <summary>
        /// El filtro solamente para usuarios con errores de validación.
        /// </summary>
        public SwitchParameter HasErrorsOnly { get; set; }

        /// <summary>
        /// El filtro solamente para usuarios que requieran la conciliación de licencias.
        /// </summary>
        public SwitchParameter LicenseReconciliationNeededOnly { get; set; }

        /// <summary>
        /// El identificador del usuario que se va a recuperar.
        /// </summary>
        public string LiveId  { get; set; }

        /// <summary>
        /// El número máximo de resultados devueltos para una búsqueda. 
        /// Si no se especifica, se devuelven 500 resultados.
        /// </summary>
        public int MaxResults  { get; set; }

        /// <summary>
        /// The unique ID of the user to retrieve.
        /// </summary>
        public Guid ObjectId  { get; set; }

        /// <summary>
        /// Si se establece, solo se eliminan los usuarios que estén en la papelera de reciclaje.
        /// </summary>
        public SwitchParameter ReturnDeletedUsers { get; set; }

        /// <summary>
        /// La cadena para buscar usuarios. 
        /// Solamente se devolverán los usuarios cuya dirección de correo electrónico o nombre para mostrar empiecen con esta cadena.
        /// </summary>
        public string SearchString { get; set; }

        /// <summary>
        /// El filtro para el estado del usuario.
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// El filtro solamente para usuarios que estén sincronizados mediante la sincronización de Windows Azure Active Directory.
        /// </summary>
        public SwitchParameter Synchronized { get; set; }

        /// <summary>
        /// El identificador único del inquilino en que se realizará la operación. 
        /// Si no se proporciona, se usará de forma predeterminada el valor del inquilino del usuario actual. 
        /// Este parámetro solamente es aplicable para usuarios asociados.
        /// </summary>
        public Guid TenantId  { get; set; }

        /// <summary>
        /// El filtro para el cargo del usuario.
        /// </summary>
        public string Title  { get; set; }

        /// <summary>
        /// El filtro solamente para usuarios que no tengan asignada una licencia.
        /// </summary>
        public SwitchParameter UnlicensedUsersOnly { get; set; }

        /// <summary>
        /// El filtro para el país en que el usuario consume los servicios. 
        /// Debe ser un código de país de dos letras. 
        /// </summary>
        public string UsageLocation { get; set; }

        /// <summary>
        /// The user ID of the user to retrieve.
        /// </summary>
        public string UserPrincipalName { get; set; }
    }
}
