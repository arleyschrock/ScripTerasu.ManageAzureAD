using System;
using System.Security;
using System.Text.RegularExpressions;

namespace ScripTerasu.ManageAzureAD.Helpers
{
    public static class StringExtensions
    {
        [SecurityCritical]
        public static SecureString ToSecureString(this string source)
        {
            if (source == null)
                return (SecureString)null;
            SecureString secureString = new SecureString();
            foreach (char c in source)
                secureString.AppendChar(c);
            secureString.MakeReadOnly();
            return secureString;
        }

        public static bool IsValidEmail(string email)
        {
            if (IsStringMissing(email))
                return false;

            // This regex pattern came from: http://haacked.com/archive/2007/08/21/i-knew-how-to-validate-an-email-address-until-i.aspx
            string pattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";

            return Regex.IsMatch(email, pattern, RegexOptions.IgnoreCase);
        }

        public static bool IsStringMissing(string value)
        {
            return
                String.IsNullOrEmpty(value) ||
                value.Trim() == String.Empty;
        }
    }
}
