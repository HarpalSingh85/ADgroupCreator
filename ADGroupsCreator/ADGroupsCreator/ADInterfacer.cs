using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADGroupsCreator
{
    internal class ADInterfacer
    {
        public enum GroupType : uint
        {
            GLOBAL = 0x2,
            DOMAIN_LOCAL = 0x4,
            UNIVERSAL = 0x8,
            SECURITY = 0x80000000
        }

        public string OuPath { get; private set; }

        public string Result { get; private set; } = null;

        internal ADInterfacer(string _OuPath)
        {


            if (_OuPath == "United Kingdom")
            {
                OuPath = "OU=Groups,OU=United Kingdom,DC=vaa,DC=vtg,DC=local";
            }
            if (_OuPath == "United States")
            {
                OuPath = "OU=Groups,OU=United States,DC=vaa,DC=vtg,DC=local";
            }
        }

        public string Create(string _name, string _description, string _notes)
        {
            if (!DirectoryEntry.Exists("LDAP://CN=" + _name + "," + OuPath))
            {
                try
                {
                    var groupType = unchecked((int)(GroupType.DOMAIN_LOCAL | GroupType.SECURITY));
                    DirectoryEntry entry = new DirectoryEntry("LDAP://" + OuPath);
                    DirectoryEntry group = entry.Children.Add("CN=" + _name, "group");
                    group.Properties["sAmAccountName"].Value = _name;
                    group.Properties["groupType"].Value = groupType;
                    group.Properties["Description"].Value = _description;
                    group.Properties["Info"].Value = _notes;
                    group.CommitChanges();

                    if (OuPath.Equals("OU=Groups,OU=United Kingdom,DC=vaa,DC=vtg,DC=local"))
                    { Result = $"Successfully added to United Kingdom OU in AD."; }
                    if (OuPath.Equals("OU=Groups,OU=United States,DC=vaa,DC=vtg,DC=local"))
                    { Result = $"Successfully added to United States OU in AD."; }

                }
                catch (Exception e)
                {
                    if (e.Message.Equals("The object already exists.\r\n"))
                    { throw new GroupAlreadyExistsException(_name); }
                    else
                    {
                        throw e;
                    }
                    
                }
            }

            else { throw new GroupAlreadyExistsException(_name); }

            return Result;
        }
        
    }

    class GroupAlreadyExistsException : Exception
    {
        public GroupAlreadyExistsException()
        {

        }

        public GroupAlreadyExistsException(string name)
            : base(String.Format($"AD Group already exists : {name}"))
        {

        }

    }
}
