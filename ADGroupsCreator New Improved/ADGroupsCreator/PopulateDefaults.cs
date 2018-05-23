using System.Collections.Generic;

namespace ADGroupsCreator
{
   internal class PopulateDefaults
    {
        public List<string> Geography { get; private set; }
        public List<string> PermissionLevel { get; private set; }
        internal PopulateDefaults()
        {
            List<string> _geography = new List<string>();
            List<string> _permissionlevel = new List<string>();
            _geography.Add("United Kingdom");
            _geography.Add("United States");
            _permissionlevel.Add("Read Only");
            _permissionlevel.Add("Modify");
            Geography = _geography;
            PermissionLevel = _permissionlevel;
         }

        public List<string> GetGeography()
        {
            return Geography;
        }

        public List<string> GetPermissionLevel()
        {
            return PermissionLevel;
        }
    }
}
