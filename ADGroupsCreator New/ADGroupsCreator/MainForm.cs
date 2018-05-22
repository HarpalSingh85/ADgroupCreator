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
            panelMain.Visible = true;
            panelChild.Visible = false;
            btnBack.Visible = false;
            BtnNext.Visible = true;

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
                statusLbl.ForeColor = Color.DarkRed;
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

            
            if (String.IsNullOrWhiteSpace(_share))
            {            
                
                lblValidation.Text = "";
                lblValidation.BackColor = Color.WhiteSmoke;
                txtBoxSuggestion.Text = "";
            }
        }
               

        private void txtBoxGroupName_TextChanged(object sender, EventArgs e)
        {           
            if (chkboxPopulate.Checked)
            {
                txtBoxGroupName.Text = txtBoxSuggestion.Text;
                if (!String.IsNullOrWhiteSpace(DataPreview.previewGrpName(txtBoxSuggestion.Text)))
                { lstBoxPreview.Items.Add(DataPreview.previewGrpName(txtBoxSuggestion.Text)); }
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

           // if (txtBoxTask.Text != "" && txtBoxRITM.Text != "" && txtBoxShare.Text != "")
            if (!String.IsNullOrWhiteSpace(txtBoxTask.Text) && !String.IsNullOrWhiteSpace(txtBoxRITM.Text) && !String.IsNullOrWhiteSpace(txtBoxShare.Text))
                {
                
                string description = $"{AccessLvl} Access to : {txtBoxShare.Text}";
                string notes = $"Task No : {txtBoxTask.Text}\r\nRITM No : {txtBoxRITM.Text}";

                try
                {
                    ADInterfacer Adi = new ADInterfacer(_ouPath);
                    statusLbl.Text = Adi.Create(txtBoxGroupName.Text, description, notes);
                    statusLbl.ForeColor = Color.DarkGreen;
                    ImageSuccess();
                }
                catch(GroupAlreadyExistsException ex)
                {
                    statusLbl.Text = ex.Message;
                    statusLbl.ForeColor = Color.DarkRed;
                    ImageFailure();
                }

                catch (Exception ex)
                {
                    statusLbl.Text = ex.Message.Replace("\r\n","");
                    statusLbl.ForeColor = Color.DarkRed;
                    ImageFailure();
                }
            }

            else
            {
                statusLbl.Text = "Task and RITM fields cannot be empty";
                statusLbl.ForeColor = Color.DarkRed;
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
                    statusLbl.ForeColor = Color.DarkRed;
                    ImageFailure();
                }
                else
                {
                    statusLbl.Text = "TASK number validated successfully";
                    statusLbl.ForeColor = Color.DarkGreen;
                    ImageSuccess();
                }
            }
            else
            {
                statusLbl.Text = "";
                statusLbl.ForeColor = Color.Black;
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
                    statusLbl.ForeColor = Color.DarkRed;
                    ImageFailure();
                }
                else
                {
                    statusLbl.Text = "RITM number validated successfully";
                    statusLbl.ForeColor = Color.DarkGreen;
                    ImageSuccess();
                }
            }
            else
            {
                statusLbl.Text = "";
                statusLbl.ForeColor = Color.Black;
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
            statusLbl.Image = new Bitmap(ADGroupsCreator.Properties.Resources.Correct);
            statusLbl.ImageAlign = ContentAlignment.MiddleRight;
        }

        private void ImageFailure()
        {
            statusLbl.Visible = true;
            statusLbl.Image = new Bitmap(ADGroupsCreator.Properties.Resources.Wrong);
            statusLbl.ImageAlign = ContentAlignment.MiddleRight;
        }
        
        private void ImageReset()
        {
            statusLbl.Image = new Bitmap(1, 1);
            statusLbl.Visible = false;
        }

        #endregion

        private void BtnNext_Click(object sender, EventArgs e)
        {
            panelChild.Visible = true;
            panelMain.Visible = false;
            panelChild.BringToFront();
            panelChild.Show();
            btnBack.Visible = true;
            BtnNext.Visible = false;

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            panelMain.Visible = true;
            panelChild.Visible = false;
            panelMain.BringToFront();
            panelMain.Show();
            BtnNext.Visible = true;
            btnBack.Visible = false;
        }
    }
}
