namespace ADGroupsCreator
{
    partial class mainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.panelGrpA = new System.Windows.Forms.Panel();
            this.txtBoxRITM = new System.Windows.Forms.TextBox();
            this.txtBoxTask = new System.Windows.Forms.TextBox();
            this.lblRITM = new System.Windows.Forms.Label();
            this.lblTask = new System.Windows.Forms.Label();
            this.chkboxPopulate = new System.Windows.Forms.CheckBox();
            this.cmbBoxGrography = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxCurrentDc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxGroupName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.panelGrpB = new System.Windows.Forms.Panel();
            this.cmbBoxPermissionLevel = new System.Windows.Forms.ComboBox();
            this.lblPermissionLevel = new System.Windows.Forms.Label();
            this.lblValidation = new System.Windows.Forms.Label();
            this.txtBoxSuggestion = new System.Windows.Forms.TextBox();
            this.txtBoxShare = new System.Windows.Forms.TextBox();
            this.btnUpdateAD = new System.Windows.Forms.Button();
            this.panelGrpA.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panelGrpB.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelGrpA
            // 
            this.panelGrpA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelGrpA.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelGrpA.Controls.Add(this.txtBoxRITM);
            this.panelGrpA.Controls.Add(this.txtBoxTask);
            this.panelGrpA.Controls.Add(this.lblRITM);
            this.panelGrpA.Controls.Add(this.lblTask);
            this.panelGrpA.Controls.Add(this.chkboxPopulate);
            this.panelGrpA.Controls.Add(this.cmbBoxGrography);
            this.panelGrpA.Controls.Add(this.label3);
            this.panelGrpA.Controls.Add(this.txtBoxCurrentDc);
            this.panelGrpA.Controls.Add(this.label2);
            this.panelGrpA.Controls.Add(this.txtBoxGroupName);
            this.panelGrpA.Controls.Add(this.label1);
            this.panelGrpA.Location = new System.Drawing.Point(12, 12);
            this.panelGrpA.Name = "panelGrpA";
            this.panelGrpA.Size = new System.Drawing.Size(560, 114);
            this.panelGrpA.TabIndex = 0;
            // 
            // txtBoxRITM
            // 
            this.txtBoxRITM.BackColor = System.Drawing.SystemColors.Window;
            this.txtBoxRITM.Location = new System.Drawing.Point(306, 74);
            this.txtBoxRITM.Name = "txtBoxRITM";
            this.txtBoxRITM.Size = new System.Drawing.Size(111, 20);
            this.txtBoxRITM.TabIndex = 11;
            this.txtBoxRITM.TextChanged += new System.EventHandler(this.txtBoxRITM_TextChanged);
            this.txtBoxRITM.Leave += new System.EventHandler(this.txtBoxRITM_Leave);
            // 
            // txtBoxTask
            // 
            this.txtBoxTask.BackColor = System.Drawing.SystemColors.Window;
            this.txtBoxTask.Location = new System.Drawing.Point(306, 43);
            this.txtBoxTask.Name = "txtBoxTask";
            this.txtBoxTask.Size = new System.Drawing.Size(111, 20);
            this.txtBoxTask.TabIndex = 10;
            this.txtBoxTask.TextChanged += new System.EventHandler(this.txtBoxTask_TextChanged);
            this.txtBoxTask.Leave += new System.EventHandler(this.txtBoxTask_Leave);
            // 
            // lblRITM
            // 
            this.lblRITM.AutoSize = true;
            this.lblRITM.Location = new System.Drawing.Point(249, 77);
            this.lblRITM.Name = "lblRITM";
            this.lblRITM.Size = new System.Drawing.Size(51, 13);
            this.lblRITM.TabIndex = 9;
            this.lblRITM.Text = "RITM No";
            this.lblRITM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTask
            // 
            this.lblTask.AutoSize = true;
            this.lblTask.Location = new System.Drawing.Point(249, 47);
            this.lblTask.Name = "lblTask";
            this.lblTask.Size = new System.Drawing.Size(52, 13);
            this.lblTask.TabIndex = 8;
            this.lblTask.Text = "TASK No";
            this.lblTask.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chkboxPopulate
            // 
            this.chkboxPopulate.AutoSize = true;
            this.chkboxPopulate.Location = new System.Drawing.Point(446, 43);
            this.chkboxPopulate.Name = "chkboxPopulate";
            this.chkboxPopulate.Size = new System.Drawing.Size(93, 17);
            this.chkboxPopulate.TabIndex = 7;
            this.chkboxPopulate.Text = "Auto Populate";
            this.chkboxPopulate.UseVisualStyleBackColor = true;
            this.chkboxPopulate.CheckedChanged += new System.EventHandler(this.chkboxPopulate_CheckedChanged);
            // 
            // cmbBoxGrography
            // 
            this.cmbBoxGrography.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxGrography.FormattingEnabled = true;
            this.cmbBoxGrography.Location = new System.Drawing.Point(101, 73);
            this.cmbBoxGrography.Name = "cmbBoxGrography";
            this.cmbBoxGrography.Size = new System.Drawing.Size(103, 21);
            this.cmbBoxGrography.TabIndex = 6;
            this.cmbBoxGrography.SelectedValueChanged += new System.EventHandler(this.cmbBoxGrography_SelectedValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Geography";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBoxCurrentDc
            // 
            this.txtBoxCurrentDc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtBoxCurrentDc.Location = new System.Drawing.Point(101, 43);
            this.txtBoxCurrentDc.Name = "txtBoxCurrentDc";
            this.txtBoxCurrentDc.ReadOnly = true;
            this.txtBoxCurrentDc.Size = new System.Drawing.Size(111, 20);
            this.txtBoxCurrentDc.TabIndex = 4;
            this.txtBoxCurrentDc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Current DC";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBoxGroupName
            // 
            this.txtBoxGroupName.Location = new System.Drawing.Point(101, 12);
            this.txtBoxGroupName.Name = "txtBoxGroupName";
            this.txtBoxGroupName.Size = new System.Drawing.Size(441, 20);
            this.txtBoxGroupName.TabIndex = 1;
            this.txtBoxGroupName.TextChanged += new System.EventHandler(this.txtBoxGroupName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "AD Group Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(481, 298);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLbl});
            this.statusStrip1.Location = new System.Drawing.Point(0, 336);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(584, 25);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLbl
            // 
            this.statusLbl.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.statusLbl.Image = global::ADGroupsCreator.Properties.Resources.Error;
            this.statusLbl.Name = "statusLbl";
            this.statusLbl.Size = new System.Drawing.Size(20, 20);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(400, 298);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnGenerate.TabIndex = 5;
            this.btnGenerate.Text = "&Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // panelGrpB
            // 
            this.panelGrpB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelGrpB.Controls.Add(this.cmbBoxPermissionLevel);
            this.panelGrpB.Controls.Add(this.lblPermissionLevel);
            this.panelGrpB.Controls.Add(this.lblValidation);
            this.panelGrpB.Controls.Add(this.txtBoxSuggestion);
            this.panelGrpB.Controls.Add(this.txtBoxShare);
            this.panelGrpB.Location = new System.Drawing.Point(12, 137);
            this.panelGrpB.Name = "panelGrpB";
            this.panelGrpB.Size = new System.Drawing.Size(560, 146);
            this.panelGrpB.TabIndex = 6;
            // 
            // cmbBoxPermissionLevel
            // 
            this.cmbBoxPermissionLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxPermissionLevel.FormattingEnabled = true;
            this.cmbBoxPermissionLevel.Location = new System.Drawing.Point(107, 110);
            this.cmbBoxPermissionLevel.Name = "cmbBoxPermissionLevel";
            this.cmbBoxPermissionLevel.Size = new System.Drawing.Size(96, 21);
            this.cmbBoxPermissionLevel.TabIndex = 8;
            this.cmbBoxPermissionLevel.SelectedIndexChanged += new System.EventHandler(this.cmbBoxPermissionLevel_SelectedIndexChanged);
            // 
            // lblPermissionLevel
            // 
            this.lblPermissionLevel.AutoSize = true;
            this.lblPermissionLevel.Location = new System.Drawing.Point(13, 115);
            this.lblPermissionLevel.Name = "lblPermissionLevel";
            this.lblPermissionLevel.Size = new System.Drawing.Size(86, 13);
            this.lblPermissionLevel.TabIndex = 4;
            this.lblPermissionLevel.Text = "Permission Level";
            this.lblPermissionLevel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblValidation
            // 
            this.lblValidation.BackColor = System.Drawing.Color.LightGray;
            this.lblValidation.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblValidation.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblValidation.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValidation.Location = new System.Drawing.Point(446, 8);
            this.lblValidation.Name = "lblValidation";
            this.lblValidation.Size = new System.Drawing.Size(96, 23);
            this.lblValidation.TabIndex = 3;
            this.lblValidation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBoxSuggestion
            // 
            this.txtBoxSuggestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtBoxSuggestion.Location = new System.Drawing.Point(10, 76);
            this.txtBoxSuggestion.Name = "txtBoxSuggestion";
            this.txtBoxSuggestion.ReadOnly = true;
            this.txtBoxSuggestion.Size = new System.Drawing.Size(532, 20);
            this.txtBoxSuggestion.TabIndex = 2;
            // 
            // txtBoxShare
            // 
            this.txtBoxShare.Location = new System.Drawing.Point(10, 8);
            this.txtBoxShare.Multiline = true;
            this.txtBoxShare.Name = "txtBoxShare";
            this.txtBoxShare.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBoxShare.Size = new System.Drawing.Size(430, 62);
            this.txtBoxShare.TabIndex = 0;
            this.txtBoxShare.TextChanged += new System.EventHandler(this.txtBoxShare_TextChanged);
            // 
            // btnUpdateAD
            // 
            this.btnUpdateAD.Location = new System.Drawing.Point(319, 298);
            this.btnUpdateAD.Name = "btnUpdateAD";
            this.btnUpdateAD.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateAD.TabIndex = 7;
            this.btnUpdateAD.Text = "&Update AD";
            this.btnUpdateAD.UseVisualStyleBackColor = true;
            this.btnUpdateAD.Click += new System.EventHandler(this.btnUpdateAD_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.btnUpdateAD);
            this.Controls.Add(this.panelGrpB);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.panelGrpA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "mainForm";
            this.Text = "AD Groups Creator Internal Test Release Only";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.panelGrpA.ResumeLayout(false);
            this.panelGrpA.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panelGrpB.ResumeLayout(false);
            this.panelGrpB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelGrpA;
        private System.Windows.Forms.CheckBox chkboxPopulate;
        private System.Windows.Forms.ComboBox cmbBoxGrography;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxCurrentDc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxGroupName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.ToolStripStatusLabel statusLbl;
        private System.Windows.Forms.Panel panelGrpB;
        private System.Windows.Forms.ComboBox cmbBoxPermissionLevel;
        private System.Windows.Forms.Label lblPermissionLevel;
        private System.Windows.Forms.Label lblValidation;
        private System.Windows.Forms.TextBox txtBoxSuggestion;
        private System.Windows.Forms.TextBox txtBoxShare;
        private System.Windows.Forms.Button btnUpdateAD;
        private System.Windows.Forms.TextBox txtBoxRITM;
        private System.Windows.Forms.TextBox txtBoxTask;
        private System.Windows.Forms.Label lblRITM;
        private System.Windows.Forms.Label lblTask;
    }
}

