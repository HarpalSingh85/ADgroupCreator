using System.DirectoryServices;

namespace DefaultNamingContext
{
    class DefaultNamingContext
    {
        internal string GetDefaultNamingContext()
        {
            string defaultNamingContext;
            using (DirectoryEntry rootDSE = new DirectoryEntry("LDAP://RootDSE"))
            {
                defaultNamingContext = rootDSE.Properties["defaultNamingContext"].Value.ToString();
            }

            return defaultNamingContext;
        }
    }
}
