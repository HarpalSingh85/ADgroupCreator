using System;
using System.DirectoryServices.ActiveDirectory;

namespace ADGroupsCreator
{
    internal class GetCurrentDomain
    {
        public string CurrentDomain { get; set; }

       internal GetCurrentDomain()
        {
            try
            {
                var _domain = Domain.GetCurrentDomain();
                if (_domain != null)
                {
                    var curName = _domain.FindDomainController().ToString();
                    string[] cList = (curName.Split('.'));
                    CurrentDomain = cList[0];
                }
                else
                {
                    throw new ArgumentNullException();
                }

            }
            catch(Exception ex)
            {
                throw ex;
            }        
        }

    }
}
