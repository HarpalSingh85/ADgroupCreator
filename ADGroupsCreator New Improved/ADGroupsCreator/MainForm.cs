using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace ADGroupsCreator
{
    public partial class mainForm : Form
    {
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern bool EnableMenuItem(IntPtr hMenu, uint uIDEnableItem, uint uEnable);

        const int MF_BYCOMMAND = 0;
        const int MF_DISABLED = 2;
        const int SC_CLOSE = 0xF060;

        private string _ouPath = null;
        public string AccessLvl { get; private set; }
        public string GrpName { get; set; }
        public string SharedPath { get; set; }
        public string AccessType { get; set; }        
        Regex rgxTASK = new Regex(@"^TASK\d{5,9}");
        Regex rgxRITM = new Regex(@"^RITM\d{5,9}");

        public mainForm()
        {
            InitializeComponent();
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {            
            panelMain.Visible = true;
            panelChild.Visible = false;
            progressBarPermStats.Visible = false;
            btnBack.Visible = false;
            BtnNext.Visible = true;
            btnApplyPermission.Visible = false;
            dataGridView.Rows.Clear();
            dataGridView.RowHeadersVisible = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.Columns[dataGridView.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            panelMain.Show();

            PopulateDefaults defaults = new PopulateDefaults();
            cmbBoxGrography.DataSource = defaults.Geography;
            cmbBoxPermissionLevel.DataSource = defaults.PermissionLevel;
            cmbBoxGrography.SelectedIndex = 0;
            cmbBoxPermissionLevel.SelectedIndex = 0;
            chkboxPopulate.CheckState = CheckState.Checked;
                        

            try
            {
                GetCurrentDomain dc = new GetCurrentDomain();
                lblCurrentDC.Text = dc.CurrentDomain;
            }
            catch(Exception Ex)
            {
                statusLbl.Text = Ex.Message.Replace("\r\n", "");
                ImageFailure();
            }                              
                       
        }

        private void txtBoxShare_TextChanged(object sender, EventArgs e)
        {   
             Validator(txtBoxShare.Text, cmbBoxPermissionLevel.SelectedValue.ToString());
            if (chkboxPopulate.Checked)
            {
                txtBoxGroupName.Text = txtBoxSuggestion.Text;

            }
        }

        private void cmbBoxPermissionLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            Validator(txtBoxShare.Text, cmbBoxPermissionLevel.SelectedValue.ToString());
            if (chkboxPopulate.Checked)
            {
                txtBoxGroupName.Text = txtBoxSuggestion.Text;

            }

        }

        private async void Validator(string _share, string _permlevel)
        {
            if ( await Task.Run(()=>Directory.Exists(_share)))
            {
                
                lblValidation.BackColor = Color.FromArgb(40, 40, 40);
                lblValidation.ForeColor = Color.GreenYellow;
                lblValidation.Text = "Valid Share";
                if (_share.Length >= 15)
                {

                    try
                    {
                        NameSuggester ns = new NameSuggester(_share, _permlevel);
                        txtBoxSuggestion.Text = ns.suggestName();
                    }
                    catch (Exception ex)
                    {
                        statusLbl.Text = ex.Message;                       
                    }
                }
                else
                {
                    txtBoxSuggestion.Text = "";
                }
            }
            else
            {
                
                lblValidation.BackColor = Color.FromArgb(40, 40, 40);
                lblValidation.ForeColor = Color.Orange;
                lblValidation.Text = "Invalid Share";
                txtBoxSuggestion.Text = "";
                ImageReset();
            }

            
            if (String.IsNullOrWhiteSpace(_share))
            {            
                
                lblValidation.Text = "";
                lblValidation.BackColor = Color.WhiteSmoke;
                txtBoxSuggestion.Text = "";
                lstBoxPreview.BackColor = Color.WhiteSmoke;
                lstBoxPreview.Items.Clear();
            }
        }
               

        private void txtBoxGroupName_TextChanged(object sender, EventArgs e)
        {           
            if (chkboxPopulate.Checked)
            {
                txtBoxGroupName.Text = txtBoxSuggestion.Text;
                if (!String.IsNullOrWhiteSpace(DataPreview.previewGrpName(txtBoxSuggestion.Text)))
                {
                    lstBoxPreview.BackColor = Color.Black;
                    lstBoxPreview.Items.Add(DataPreview.previewGrpName(txtBoxSuggestion.Text));
                }
            }

        }

        private void txtBoxSuggestion_TextChanged(object sender, EventArgs e)
        {
            txtBoxGroupName.Text = txtBoxSuggestion.Text;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            Validator(txtBoxShare.Text, cmbBoxPermissionLevel.SelectedValue.ToString());
        }

        private void chkboxPopulate_CheckedChanged(object sender, EventArgs e)
        {
            if(chkboxPopulate.Checked)
            {
                txtBoxGroupName.Text = txtBoxSuggestion.Text;
            }
            
        }

        private void cmbBoxGrography_SelectedValueChanged(object sender, EventArgs e)
        {
            if(cmbBoxGrography.SelectedIndex == 0)
            {
                _ouPath = "United Kingdom";
            }
            else
            {
                _ouPath = "United States";
            }
        }

        private void btnUpdateAD_Click(object sender, EventArgs e)
        {
            if (cmbBoxGrography.SelectedIndex == 0)
            {
                _ouPath = "United Kingdom";
            }
            else
            {
                _ouPath = "United States";
            }

            if(cmbBoxPermissionLevel.SelectedValue.ToString() == "Read Only")
            {
                AccessLvl = "Read Only";
            }
            else
            {
                AccessLvl = "Modify";
            }
                       
            if (!String.IsNullOrWhiteSpace(txtBoxTask.Text) && !String.IsNullOrWhiteSpace(txtBoxRITM.Text) && !String.IsNullOrWhiteSpace(txtBoxShare.Text))
                {
                
                string description = $"{AccessLvl} Access to : {txtBoxShare.Text}";
                string notes = $"Task No : {txtBoxTask.Text}\r\nRITM No : {txtBoxRITM.Text}";

                try
                {
                    ADInterfacer Adi = new ADInterfacer(_ouPath);
                    statusLbl.Text = Adi.Create(txtBoxGroupName.Text, description, notes);
                    lstBoxPreview.Items.Clear();
                    lstBoxPreview.Items.Add($"Group Name : {txtBoxGroupName.Text}");
                    lstBoxPreview.Items.Add($"Share Name : {(txtBoxShare.Text).ToUpper()}");
                    lstBoxPreview.Items.Add($"{statusLbl.Text}");
                    ImageSuccess();
                }
                catch(GroupAlreadyExistsException ex)
                {
                    statusLbl.Text = ex.Message;                    
                    ImageFailure();
                }

                catch (Exception ex)
                {
                    statusLbl.Text = ex.Message.Replace("\r\n","");                    
                    ImageFailure();
                }
            }

            else
            {
                statusLbl.Text = "Task and RITM fields cannot be empty";                
                ImageFailure();
            }
                        
        }

        private void txtBoxTask_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtBoxTask.Text))
            {
                if (!rgxTASK.IsMatch(txtBoxTask.Text))
                {
                    statusLbl.Text = "TASK number appears to be incorrect";                    
                    ImageFailure();
                }
                else
                {
                    statusLbl.Text = "TASK number validated successfully";                    
                    ImageSuccess();
                }
            }
            else
            {
                statusLbl.Text = "";                
                ImageReset();
            }
        }

        private void txtBoxRITM_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtBoxRITM.Text))
            {
                if (!rgxRITM.IsMatch(txtBoxRITM.Text))
                {
                    statusLbl.Text = "RITM number appears to be incorrect";                    
                    ImageFailure();
                }
                else
                {
                    statusLbl.Text = "RITM number validated successfully";                    
                    ImageSuccess();
                }
            }
            else
            {
                statusLbl.Text = "";
                ImageReset();
            }

        }

        private void txtBoxTask_Leave(object sender, EventArgs e)
        {
            statusLbl.Text = "";
            statusLbl.ForeColor = Color.Black;
            ImageReset();
        }

        private void txtBoxRITM_Leave(object sender, EventArgs e)
        {
            statusLbl.Text = "";
            statusLbl.ForeColor = Color.Black;
            ImageReset();
        }


        #region ImageControls

        private void ImageSuccess()
        {
            statusLbl.Visible = true;
            statusLbl.ForeColor = Color.DarkGreen;
            statusLbl.Image = new Bitmap(ADGroupsCreator.Properties.Resources.Correct);
            statusLbl.ImageAlign = ContentAlignment.MiddleRight;
        }

        private void ImageFailure()
        {
            statusLbl.Visible = true;
            statusLbl.ForeColor = Color.DarkRed;
            statusLbl.Image = new Bitmap(ADGroupsCreator.Properties.Resources.Wrong);
            statusLbl.ImageAlign = ContentAlignment.MiddleRight;
        }
        
        private void ImageReset()
        {
            statusLbl.ForeColor = Color.Black;
            statusLbl.Image = new Bitmap(1, 1);
            statusLbl.Visible = false;
        }

        #endregion

        private void BtnNext_Click(object sender, EventArgs e)
        {
            ImageReset();
            txtBoxpnBADGroup.ForeColor = Color.FromArgb(64, 64, 64);
            txtBoxpnBShare.ForeColor = Color.FromArgb(64, 64, 64);
            btnGenerate.Visible = false;
            btnUpdateAD.Visible = false;
            btnApplyPermission.Visible = true;
            panelChild.Visible = true;
            panelMain.Visible = false;
            panelChild.BringToFront();
            panelChild.Show();
            btnBack.Visible = true;
            BtnNext.Visible = false;            
            txtBoxpnBShare.Text = txtBoxShare.Text;
            txtBoxpnBADGroup.Text = txtBoxGroupName.Text;
            statusLbl.Visible = true;
            statusLbl.Text = "";
                        
            if(!String.IsNullOrEmpty(txtBoxShare.Text))
            {

                dataGridView.Rows.Clear();
                Evaluate(txtBoxShare.Text.Trim());
            }
            else
            {
                ImageFailure();
                statusLbl.Text = "Enter shared path to be evaluated";
            }


        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ImageReset();
            btnGenerate.Visible = true;
            btnUpdateAD.Visible = true;
            btnApplyPermission.Visible = false;
            panelMain.Visible = true;
            panelChild.Visible = false;
            panelMain.BringToFront();
            panelMain.Show();
            BtnNext.Visible = true;
            btnBack.Visible = false;
            dataGridView.Rows.Clear();
            statusLbl.Visible = true;
            statusLbl.Text = "";
        }

        private async void btnApplyPermission_Click(object sender, EventArgs e)
        {                       
            if (!String.IsNullOrWhiteSpace(txtBoxShare.Text))
            {
                if (!String.IsNullOrWhiteSpace(txtBoxGroupName.Text))
                {
                    GrpName = txtBoxGroupName.Text.Trim();
                    SharedPath = txtBoxShare.Text.Trim();
                    AccessType = cmbBoxPermissionLevel.Text;

                    try
                    {
                        btnExit.Enabled = false;
                        progressBarPermStats.Visible = true;
                        progressBarPermStats.MarqueeAnimationSpeed = 30;
                        var fromCloseHandle = GetSystemMenu(Handle, false);
                        EnableMenuItem(fromCloseHandle, SC_CLOSE, MF_BYCOMMAND | MF_DISABLED);

                        //Applypermissionanimation();

                        SetFolderPermission newperms = new SetFolderPermission(GrpName, SharedPath, AccessType);
                        newperms.PermTaskCompleted += Newperms_PermTaskCompleted;
                        var _watch = System.Diagnostics.Stopwatch.StartNew();
                        var result = await newperms.AddFolderPermissionAsync();
                        _watch.Stop();

                        // TotalTimeElapsed = $"Task Completed & Total Time Elasped : { _watch.Elapsed}";
                        ImageSuccess();
                        statusLbl.Text = $"Task Completed in : " + String.Format("{0:00}:{1:00}:{2:00}",_watch.Elapsed.TotalHours ,_watch.Elapsed.TotalMinutes , _watch.Elapsed.TotalSeconds);
                        lstBoxPreview.Items.Clear();
                        lstBoxPreview.Items.Add($"Group Name : {txtBoxGroupName.Text}");
                        lstBoxPreview.Items.Add($"Share Name : {(txtBoxShare.Text).ToUpper()}");
                        lstBoxPreview.Items.Add($"Task Completed in : " + String.Format("{0:00}:{1:00}:{2:00}", _watch.Elapsed.TotalHours, _watch.Elapsed.TotalMinutes, _watch.Elapsed.TotalSeconds));
                        lstBoxPreview.Items.Add($"Permission applied Successfully");
                        dataGridView.Rows.Clear();
                        Evaluate(txtBoxShare.Text.Trim());

                    }
                    catch (Exception ex)
                    {
                        if (ex is DirectoryNotFoundException)
                        {
                            statusLbl.Text = ex.Message + " is not accessible";
                            Newperms_PermTaskCompleted(this,EventArgs.Empty);
                        }
                        else
                        {
                            statusLbl.Text = ex.Message;
                            Newperms_PermTaskCompleted(this, EventArgs.Empty);
                        }

                    }


                }
                else
                {
                    statusLbl.Text = "Please enter group name for which permission will be applied";
                }
            }
            else
            {
                statusLbl.Text = "Enter shared path to be evaluated";
            }

        }

        private async void Evaluate(string path)
        {
            GetFolderPermission perm = new GetFolderPermission(path);

            try
            {
                var perms = await perm.GetPermissionAsync();

                foreach (var item in perms)
                {

                    dataGridView.Rows.Add(item.IdentityReference, item.AccessControlType, item.FileSystemRights, item.IsInherited);
                }

            }

            catch (Exception ex)
            {
                if (ex is DirectoryNotFoundException)
                {
                    ImageFailure();
                    statusLbl.Text = ex.Message + " is not accessible";
                }
                else
                {
                    ImageFailure();
                    statusLbl.Text = ex.Message;
                }
            }


        }

        private void Newperms_PermTaskCompleted(object source, EventArgs e)
        {
            progressBarPermStats.MarqueeAnimationSpeed = 0;
            progressBarPermStats.Visible = false;
            var fromCloseHandle = GetSystemMenu(Handle, false);
            EnableMenuItem(fromCloseHandle, SC_CLOSE, MF_BYCOMMAND | MF_BYCOMMAND);
            btnExit.Enabled = true;
            ImageSuccess();
            statusLbl.Text = "Permissions Applied Successfully";
        }

        private void Applypermissionanimation()
        {
            Timer t1 = new Timer();
            t1.Interval = 400;
            t1.Enabled = true;
            t1.Tick += T1_Tick;
            statusLbl.ForeColor = Color.DarkGreen;
        }

        private void T1_Tick(object sender, EventArgs e)
        {
            if (statusLbl.ForeColor == Color.DarkGreen)
            {
                statusLbl.ForeColor = Color.White;
                statusLbl.Text = " Applying Permissions, Please wait...";
            }
            else { statusLbl.ForeColor = Color.DarkGreen; }
        }
    }
}
