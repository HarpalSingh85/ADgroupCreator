using System;
using System.IO;
using System.Security.AccessControl;
using System.Threading.Tasks;

namespace ADGroupsCreator
{
    internal class SetFolderPermission
    {

        public string Group { get; set; }
        public string FolderPath { get; set; }
        public string AccessType { get; set; }

        public delegate void PermissionTaskCompleted(object source, EventArgs e);
        public event PermissionTaskCompleted PermTaskCompleted;

        public SetFolderPermission(string _group, string _folderpath, string _accesstype)
        {
            this.Group = _group;
            this.FolderPath = _folderpath;
            this.AccessType = _accesstype;
        }


        public async Task<ProgressReport> AddFolderPermissionAsync()
        {
            ProgressReport update = new ProgressReport();

            await Task.Run(() => {


                try
                {

                    var directoryInfo = new DirectoryInfo(FolderPath);
                    var directorySecurity = directoryInfo.GetAccessControl();

                    if (AccessType.Equals("Read Only"))
                    {
                        var fileSystemRule = new FileSystemAccessRule(Group,
                                                                      FileSystemRights.ReadAndExecute,
                                                                      InheritanceFlags.ObjectInherit |
                                                                      InheritanceFlags.ContainerInherit,
                                                                      PropagationFlags.None,
                                                                      AccessControlType.Allow);


                        directorySecurity.AddAccessRule(fileSystemRule);
                        directoryInfo.SetAccessControl(directorySecurity);
                        update.result = true;


                    }
                    if (AccessType.Equals("Modify"))
                    {
                        var fileSystemRule = new FileSystemAccessRule(Group,
                                                                      FileSystemRights.Modify,
                                                                      InheritanceFlags.ObjectInherit |
                                                                      InheritanceFlags.ContainerInherit,
                                                                      PropagationFlags.None,
                                                                      AccessControlType.Allow);

                        directorySecurity.AddAccessRule(fileSystemRule);
                        directoryInfo.SetAccessControl(directorySecurity);
                        update.result = true;
                    }


                }
                catch (Exception ex)
                {
                    if (ex is System.UnauthorizedAccessException)
                    {
                        throw ex;
                    }
                    else
                    {
                        throw ex;
                    }

                }


            });

            OnTaskCompleted();
            return update;

        }

        protected virtual void OnTaskCompleted()
        {
            PermTaskCompleted?.Invoke(this, EventArgs.Empty);
        }
    }
}
