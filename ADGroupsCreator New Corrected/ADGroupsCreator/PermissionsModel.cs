using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ADGroupsCreator
{
    internal class PermissionsModel
    {
        public string IdentityReference { get; set; }
        public string AccessControlType { get; set; }

        public string FileSystemRights { get; set; }
        public bool IsInherited { get; set; }

    }
}
