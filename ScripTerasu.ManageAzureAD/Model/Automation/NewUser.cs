using ScripTerasu.ManageAzureAD.Properties;
using System;
using System.ComponentModel;
using System.Text.RegularExpressions;

namespace ScripTerasu.ManageAzureAD.Model.Automation
{
    public class NewUser : IDataErrorInfo
    {
        #region Creation

        public static NewUser CreateNewUser()
        {
            return new NewUser();
        }

        public static NewUser CreateNewUser(
            string displayName,
            string userPrincipalName)
        {
            return new NewUser
            {
                //DisplayName = displayName,
                //UserPrincipalName = userPrincipalName
            };
        }

        protected NewUser()
        {
        }

        #endregion // Creation

        #region IDataErrorInfo Members

        string IDataErrorInfo.Error { get { return null; } }

        string IDataErrorInfo.this[string propertyName]
        {
            get { return this.GetValidationError(propertyName); }
        }

        #endregion // IDataErrorInfo Members

        #region Validation

        /// <summary>
        /// Returns true if this object has no validation errors.
        /// </summary>
        public bool IsValid
        {
            get
            {
                foreach (string property in ValidatedProperties)
                    if (GetValidationError(property) != null)
                        return false;

                return true;
            }
        }

        static readonly string[] ValidatedProperties = 
        { 
            "DisplayName", 
            "UserPrincipalName",
        };

        string GetValidationError(string propertyName)
        {
            if (Array.IndexOf(ValidatedProperties, propertyName) < 0)
                return null;

            string error = null;

            switch (propertyName)
            {
                case "DisplayName":
                    error = this.ValidateDisplayName();
                    break;

                case "UserPrincipalName":
                    error = this.ValidateUserPrincipalName();
                    break;

                default:
                    //Debug.Fail("Unexpected property being validated on Customer: " + propertyName);
                    break;
            }

            return error;
        }

        string ValidateDisplayName()
        {
            //if (IsStringMissing(this.DisplayName))
            //{
            //    return Strings.NewUser_Error_MissingDisplayName;
            //}
            return null;
        }

        string ValidateUserPrincipalName()
        {
            //if (IsStringMissing(this.UserPrincipalName))
            //{
            //    return Strings.NewUser_Error_MissingUserPrincipalName;
            //}
            //else if (!IsValidUserPrincipalName(this.UserPrincipalName))
            //{
            //    return Strings.NewUser_Error_InvalidUserPrincipalName;
            //}
            return null;
        }


        #endregion // Validation
    }
}
