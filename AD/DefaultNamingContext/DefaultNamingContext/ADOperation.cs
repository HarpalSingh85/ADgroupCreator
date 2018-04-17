using System;
using System.DirectoryServices;

namespace DefaultNamingContext
{
    class ADOperation
    {
        public String Result { get; set; }
        
        internal string Create(string ouPath, string name)
        {
            if (!DirectoryEntry.Exists("LDAP://CN=" + name + "," + ouPath))
            {
                try
                {
                    // bind to the container, e.g. LDAP://cn=Users,dc=...
                    DirectoryEntry entry = new DirectoryEntry("LDAP://" + ouPath);

                    // create group entry
                    DirectoryEntry group = entry.Children.Add("CN=" + name, "group");

                    // set properties
                    group.Properties["sAmAccountName"].Value = name;

                    // save group
                    group.CommitChanges();
                    Result = "Successfully Created";
                }
                catch (Exception e)
                {
                    //Console.WriteLine(e.Message.ToString());
                    Result = e.Message.ToString();

                }
            }
            else {// Console.WriteLine("Group already exists");
                Result = "Group already exists";
            }

            return Result;
        }
    }
}
