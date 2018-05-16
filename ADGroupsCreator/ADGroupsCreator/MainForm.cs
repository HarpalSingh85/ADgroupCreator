using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace ADGroupsCreator
{
    public partial class mainForm : Form
    {
        private string _ouPath = null;
        public string AccessLvl { get; private set; }
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
            PopulateDefaults defaults = new PopulateDefaults();
            cmbBoxGrography.DataSource = defaults.Geography;
            cmbBoxPermissionLevel.DataSource = defaults.PermissionLevel;
            cmbBoxGrography.SelectedIndex = 0;
            cmbBoxPermissionLevel.SelectedIndex = 0;
            chkboxPopulate.CheckState = CheckState.Checked;
            
            
            try
            {
                GetCurrentDomain dc = new GetCurrentDomain();
                txtBoxCurrentDc.Text = dc.CurrentDomain;
            }
            catch(Exception Ex)
            {
                statusLbl.Text = Ex.Message;
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

        private void Validator(string _share, string _permlevel)
        {
            if (Directory.Exists(_share))
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
            }

            if (_share == null || _share == "")
            {
                lblValidation.Text = "";
                lblValidation.BackColor = Color.LightGray;
                txtBoxSuggestion.Text = "";
            }
        }

        

        private void txtBoxGroupName_TextChanged(object sender, EventArgs e)
        {           
            if (chkboxPopulate.Checked)
            {
                txtBoxGroupName.Text = txtBoxSuggestion.Text;
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

            if (txtBoxTask.Text != "" && txtBoxRITM.Text != "" && txtBoxShare.Text != "")
            {
                
                string description = $"{AccessLvl} Access to : {txtBoxShare.Text}";
                string notes = $"Task No : {txtBoxTask.Text}\r\nRITM No : {txtBoxRITM.Text}";

                try
                {
                    ADInterfacer Adi = new ADInterfacer(_ouPath);
                    statusLbl.Text = Adi.Create(txtBoxGroupName.Text, description, notes);
                    statusLbl.ForeColor = Color.DarkGreen;
                }
                catch(GroupAlreadyExistsException ex)
                {
                    statusLbl.Text = ex.Message;
                    statusLbl.ForeColor = Color.DarkRed;
                }

                catch (Exception ex)
                {
                    statusLbl.Text = ex.Message.Replace("\r\n","");
                    statusLbl.ForeColor = Color.DarkRed;
                }
            }

            else
            {
                statusLbl.Text = "Task and RITM fields cannot be empty";
                statusLbl.ForeColor = Color.DarkRed;
            }
        }

        private void txtBoxTask_TextChanged(object sender, EventArgs e)
        {
            if(!rgxTASK.IsMatch(txtBoxTask.Text))
            {
                statusLbl.Text = "TASK number appears to be incorrect";
                statusLbl.ForeColor = Color.DarkRed;
            }
            else
            {
                statusLbl.Text = "TASK number validated successfully";
                statusLbl.ForeColor = Color.DarkGreen;
            }
        }

        private void txtBoxRITM_TextChanged(object sender, EventArgs e)
        {
            if (!rgxRITM.IsMatch(txtBoxRITM.Text))
            {
                statusLbl.Text = "RITM number appears to be incorrect";
                statusLbl.ForeColor = Color.DarkRed;
            }
            else
            {
                statusLbl.Text = "RITM number validated successfully";
                statusLbl.ForeColor = Color.DarkGreen;
            }
        }

        private void txtBoxTask_Leave(object sender, EventArgs e)
        {
            statusLbl.Text = "";
            statusLbl.ForeColor = Color.Black;
        }

        private void txtBoxRITM_Leave(object sender, EventArgs e)
        {
            statusLbl.Text = "";
            statusLbl.ForeColor = Color.Black;
        }
    }
}
