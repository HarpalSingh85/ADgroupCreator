using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ADGroupsCreator
{
    internal class DataPreview
    {
        public static string preview(string _grpname, string _accesslevel, string _sharepath, string _task, string _ritm)
        {
            StringBuilder builder = new StringBuilder();

            string Grp = $"Group Name : {_grpname}";
            string _description = $"{_accesslevel} Access to : {_sharepath}";
            string _notes = $"Task No : {_task}\r\nRITM No : {_ritm}";

            builder.AppendLine(_grpname);
            builder.AppendLine(_description);
            builder.AppendLine(_notes);

            return builder.ToString();
        }

        public static string previewGrpName(string _grpname)
        {
            if (!String.IsNullOrWhiteSpace(_grpname))
                return $"Group Name : {_grpname}";
            else
                return null;
        
        }

        public static string previewDescription(string _accesslevel, string _sharepath)
        {
            return $"{_accesslevel} Access to : {_sharepath}";
        }

        public static string previewNotes(string _task, string _ritm)
        {
            return $"Task No : {_task}\r\nRITM No : {_ritm}";
        }
    }
}
