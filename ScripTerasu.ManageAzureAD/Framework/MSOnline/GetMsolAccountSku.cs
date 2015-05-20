using System;

namespace ScripTerasu.ManageAzureAD.Framework.MSOnline
{
    /* 
     * Get-MsolAccountSku devolverá todas las SKU que pertenecen a la compañía.
     */

    /// <summary>
    /// Recupera todas las SKU de una compañía.
    /// </summary>
    public class GetMsolAccountSku : IMsolCmdlet
    {
        private const string _CommandText = "Get-MsolAccountSku";
        public string CommandText
        {
            get { return _CommandText; }
        }


        /// <summary>
        /// El identificador único del inquilino en que se realizará la operación. 
        /// Si no se proporciona, se usará de forma predeterminada el valor del inquilino del usuario actual. 
        /// Este parámetro solamente es aplicable para usuarios asociados.
        /// </summary>
        public Guid TenantId { get; set; }

    }
}
