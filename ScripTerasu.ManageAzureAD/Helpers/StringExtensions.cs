using System.Security;

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
    }
}
