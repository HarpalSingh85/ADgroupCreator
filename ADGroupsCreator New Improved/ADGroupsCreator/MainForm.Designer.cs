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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.btnExit = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnUpdateAD = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelMain = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbBoxPermissionLevel = new System.Windows.Forms.ComboBox();
            this.lblCurrentDC = new System.Windows.Forms.Label();
            this.lblPermissionLevel = new System.Windows.Forms.Label();
            this.txtBoxRITM = new System.Windows.Forms.TextBox();
            this.txtBoxTask = new System.Windows.Forms.TextBox();
            this.lblRITM = new System.Windows.Forms.Label();
            this.lblTask = new System.Windows.Forms.Label();
            this.chkboxPopulate = new System.Windows.Forms.CheckBox();
            this.cmbBoxGrography = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxGroupName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblValidation = new System.Windows.Forms.Label();
            this.txtBoxSuggestion = new System.Windows.Forms.TextBox();
            this.txtBoxShare = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lstBoxPreview = new System.Windows.Forms.ListBox();
            this.BtnNext = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.panelChild = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblShare = new System.Windows.Forms.Label();
            this.txtBoxpnBShare = new System.Windows.Forms.TextBox();
            this.txtBoxpnBADGroup = new System.Windows.Forms.TextBox();
            this.lblAdGroup = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnApplyPermission = new System.Windows.Forms.Button();
            this.progressBarPermStats = new System.Windows.Forms.ProgressBar();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.statusStrip1.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panelChild.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.White;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnExit.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(416, 450);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.statusStrip1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLbl});
            this.statusStrip1.Location = new System.Drawing.Point(0, 488);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(576, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 16;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLbl
            // 
            this.statusLbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLbl.Name = "statusLbl";
            this.statusLbl.Size = new System.Drawing.Size(0, 17);
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.Color.White;
            this.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnGenerate.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.Location = new System.Drawing.Point(335, 450);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnGenerate.TabIndex = 8;
            this.btnGenerate.Text = "&Generate";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnUpdateAD
            // 
            this.btnUpdateAD.BackColor = System.Drawing.Color.White;
            this.btnUpdateAD.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnUpdateAD.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateAD.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnUpdateAD.Location = new System.Drawing.Point(242, 450);
            this.btnUpdateAD.Name = "btnUpdateAD";
            this.btnUpdateAD.Size = new System.Drawing.Size(87, 23);
            this.btnUpdateAD.TabIndex = 7;
            this.btnUpdateAD.Text = "&Create in AD";
            this.btnUpdateAD.UseVisualStyleBackColor = false;
            this.btnUpdateAD.Click += new System.EventHandler(this.btnUpdateAD_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Location = new System.Drawing.Point(-1, 487);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(590, 1);
            this.panel1.TabIndex = 17;
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.groupBox2);
            this.panelMain.Controls.Add(this.groupBox1);
            this.panelMain.Controls.Add(this.groupBox3);
            this.panelMain.Location = new System.Drawing.Point(3, 4);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(569, 434);
            this.panelMain.TabIndex = 18;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbBoxPermissionLevel);
            this.groupBox2.Controls.Add(this.lblCurrentDC);
            this.groupBox2.Controls.Add(this.lblPermissionLevel);
            this.groupBox2.Controls.Add(this.txtBoxRITM);
            this.groupBox2.Controls.Add(this.txtBoxTask);
            this.groupBox2.Controls.Add(this.lblRITM);
            this.groupBox2.Controls.Add(this.lblTask);
            this.groupBox2.Controls.Add(this.chkboxPopulate);
            this.groupBox2.Controls.Add(this.cmbBoxGrography);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtBoxGroupName);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(557, 150);
            this.groupBox2.TabIndex = 117;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Selector";
            // 
            // cmbBoxPermissionLevel
            // 
            this.cmbBoxPermissionLevel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbBoxPermissionLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxPermissionLevel.ForeColor = System.Drawing.Color.Black;
            this.cmbBoxPermissionLevel.FormattingEnabled = true;
            this.cmbBoxPermissionLevel.ItemHeight = 13;
            this.cmbBoxPermissionLevel.Location = new System.Drawing.Point(110, 107);
            this.cmbBoxPermissionLevel.Name = "cmbBoxPermissionLevel";
            this.cmbBoxPermissionLevel.Size = new System.Drawing.Size(96, 21);
            this.cmbBoxPermissionLevel.TabIndex = 121;
            this.cmbBoxPermissionLevel.SelectedIndexChanged += new System.EventHandler(this.cmbBoxPermissionLevel_SelectedIndexChanged);
            // 
            // lblCurrentDC
            // 
            this.lblCurrentDC.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblCurrentDC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCurrentDC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblCurrentDC.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentDC.Location = new System.Drawing.Point(111, 45);
            this.lblCurrentDC.Name = "lblCurrentDC";
            this.lblCurrentDC.Size = new System.Drawing.Size(121, 23);
            this.lblCurrentDC.TabIndex = 115;
            this.lblCurrentDC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPermissionLevel
            // 
            this.lblPermissionLevel.AutoSize = true;
            this.lblPermissionLevel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPermissionLevel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblPermissionLevel.Location = new System.Drawing.Point(7, 109);
            this.lblPermissionLevel.Name = "lblPermissionLevel";
            this.lblPermissionLevel.Size = new System.Drawing.Size(74, 15);
            this.lblPermissionLevel.TabIndex = 122;
            this.lblPermissionLevel.Text = "Permission ";
            this.lblPermissionLevel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBoxRITM
            // 
            this.txtBoxRITM.BackColor = System.Drawing.SystemColors.Window;
            this.txtBoxRITM.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxRITM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtBoxRITM.Location = new System.Drawing.Point(306, 77);
            this.txtBoxRITM.Name = "txtBoxRITM";
            this.txtBoxRITM.Size = new System.Drawing.Size(111, 21);
            this.txtBoxRITM.TabIndex = 112;
            this.txtBoxRITM.TextChanged += new System.EventHandler(this.txtBoxRITM_TextChanged);
            this.txtBoxRITM.Leave += new System.EventHandler(this.txtBoxRITM_Leave);
            // 
            // txtBoxTask
            // 
            this.txtBoxTask.BackColor = System.Drawing.SystemColors.Window;
            this.txtBoxTask.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxTask.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtBoxTask.Location = new System.Drawing.Point(306, 46);
            this.txtBoxTask.Name = "txtBoxTask";
            this.txtBoxTask.Size = new System.Drawing.Size(111, 21);
            this.txtBoxTask.TabIndex = 111;
            this.txtBoxTask.TextChanged += new System.EventHandler(this.txtBoxTask_TextChanged);
            this.txtBoxTask.Leave += new System.EventHandler(this.txtBoxTask_Leave);
            // 
            // lblRITM
            // 
            this.lblRITM.AutoSize = true;
            this.lblRITM.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRITM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblRITM.Location = new System.Drawing.Point(249, 79);
            this.lblRITM.Name = "lblRITM";
            this.lblRITM.Size = new System.Drawing.Size(54, 15);
            this.lblRITM.TabIndex = 117;
            this.lblRITM.Text = "RITM No";
            this.lblRITM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTask
            // 
            this.lblTask.AutoSize = true;
            this.lblTask.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTask.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblTask.Location = new System.Drawing.Point(249, 49);
            this.lblTask.Name = "lblTask";
            this.lblTask.Size = new System.Drawing.Size(55, 15);
            this.lblTask.TabIndex = 118;
            this.lblTask.Text = "TASK No";
            this.lblTask.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chkboxPopulate
            // 
            this.chkboxPopulate.AutoSize = true;
            this.chkboxPopulate.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkboxPopulate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.chkboxPopulate.Location = new System.Drawing.Point(446, 49);
            this.chkboxPopulate.Name = "chkboxPopulate";
            this.chkboxPopulate.Size = new System.Drawing.Size(102, 19);
            this.chkboxPopulate.TabIndex = 113;
            this.chkboxPopulate.Text = "Auto Populate";
            this.chkboxPopulate.UseVisualStyleBackColor = true;
            this.chkboxPopulate.CheckedChanged += new System.EventHandler(this.chkboxPopulate_CheckedChanged);
            // 
            // cmbBoxGrography
            // 
            this.cmbBoxGrography.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbBoxGrography.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxGrography.ForeColor = System.Drawing.Color.Black;
            this.cmbBoxGrography.FormattingEnabled = true;
            this.cmbBoxGrography.ItemHeight = 13;
            this.cmbBoxGrography.Location = new System.Drawing.Point(111, 75);
            this.cmbBoxGrography.Name = "cmbBoxGrography";
            this.cmbBoxGrography.Size = new System.Drawing.Size(111, 21);
            this.cmbBoxGrography.TabIndex = 114;
            this.cmbBoxGrography.SelectedValueChanged += new System.EventHandler(this.cmbBoxGrography_SelectedValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.label3.Location = new System.Drawing.Point(6, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 119;
            this.label3.Text = "Geography";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.label2.Location = new System.Drawing.Point(6, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 15);
            this.label2.TabIndex = 120;
            this.label2.Text = "Current DC";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBoxGroupName
            // 
            this.txtBoxGroupName.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxGroupName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtBoxGroupName.Location = new System.Drawing.Point(111, 14);
            this.txtBoxGroupName.Name = "txtBoxGroupName";
            this.txtBoxGroupName.Size = new System.Drawing.Size(441, 21);
            this.txtBoxGroupName.TabIndex = 116;
            this.txtBoxGroupName.TextChanged += new System.EventHandler(this.txtBoxGroupName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 15);
            this.label1.TabIndex = 121;
            this.label1.Text = "AD Group Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblValidation);
            this.groupBox1.Controls.Add(this.txtBoxSuggestion);
            this.groupBox1.Controls.Add(this.txtBoxShare);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox1.Location = new System.Drawing.Point(7, 162);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(556, 121);
            this.groupBox1.TabIndex = 116;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Validator";
            // 
            // lblValidation
            // 
            this.lblValidation.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblValidation.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblValidation.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblValidation.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValidation.Location = new System.Drawing.Point(445, 18);
            this.lblValidation.Name = "lblValidation";
            this.lblValidation.Size = new System.Drawing.Size(102, 25);
            this.lblValidation.TabIndex = 118;
            this.lblValidation.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // txtBoxSuggestion
            // 
            this.txtBoxSuggestion.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtBoxSuggestion.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxSuggestion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtBoxSuggestion.Location = new System.Drawing.Point(9, 86);
            this.txtBoxSuggestion.Name = "txtBoxSuggestion";
            this.txtBoxSuggestion.ReadOnly = true;
            this.txtBoxSuggestion.Size = new System.Drawing.Size(538, 21);
            this.txtBoxSuggestion.TabIndex = 117;
            this.txtBoxSuggestion.TextChanged += new System.EventHandler(this.txtBoxSuggestion_TextChanged);
            // 
            // txtBoxShare
            // 
            this.txtBoxShare.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxShare.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtBoxShare.Location = new System.Drawing.Point(9, 18);
            this.txtBoxShare.Multiline = true;
            this.txtBoxShare.Name = "txtBoxShare";
            this.txtBoxShare.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBoxShare.Size = new System.Drawing.Size(430, 62);
            this.txtBoxShare.TabIndex = 116;
            this.txtBoxShare.TextChanged += new System.EventHandler(this.txtBoxShare_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lstBoxPreview);
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox3.Location = new System.Drawing.Point(7, 288);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(556, 141);
            this.groupBox3.TabIndex = 118;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Preview";
            // 
            // lstBoxPreview
            // 
            this.lstBoxPreview.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lstBoxPreview.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstBoxPreview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lstBoxPreview.FormattingEnabled = true;
            this.lstBoxPreview.Location = new System.Drawing.Point(9, 20);
            this.lstBoxPreview.Name = "lstBoxPreview";
            this.lstBoxPreview.Size = new System.Drawing.Size(538, 108);
            this.lstBoxPreview.TabIndex = 0;
            // 
            // BtnNext
            // 
            this.BtnNext.Location = new System.Drawing.Point(497, 450);
            this.BtnNext.Name = "BtnNext";
            this.BtnNext.Size = new System.Drawing.Size(75, 23);
            this.BtnNext.TabIndex = 19;
            this.BtnNext.Text = "Next";
            this.BtnNext.UseVisualStyleBackColor = true;
            this.BtnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(497, 450);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 20;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // panelChild
            // 
            this.panelChild.Controls.Add(this.groupBox4);
            this.panelChild.Controls.Add(this.dataGridView);
            this.panelChild.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelChild.Location = new System.Drawing.Point(4, 7);
            this.panelChild.Name = "panelChild";
            this.panelChild.Size = new System.Drawing.Size(570, 434);
            this.panelChild.TabIndex = 21;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblShare);
            this.groupBox4.Controls.Add(this.txtBoxpnBShare);
            this.groupBox4.Controls.Add(this.txtBoxpnBADGroup);
            this.groupBox4.Controls.Add(this.lblAdGroup);
            this.groupBox4.Location = new System.Drawing.Point(6, -1);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(556, 82);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            // 
            // lblShare
            // 
            this.lblShare.AutoSize = true;
            this.lblShare.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShare.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblShare.Location = new System.Drawing.Point(4, 48);
            this.lblShare.Name = "lblShare";
            this.lblShare.Size = new System.Drawing.Size(77, 15);
            this.lblShare.TabIndex = 7;
            this.lblShare.Text = "Target Share";
            // 
            // txtBoxpnBShare
            // 
            this.txtBoxpnBShare.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxpnBShare.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.txtBoxpnBShare.Location = new System.Drawing.Point(83, 45);
            this.txtBoxpnBShare.Name = "txtBoxpnBShare";
            this.txtBoxpnBShare.Size = new System.Drawing.Size(466, 21);
            this.txtBoxpnBShare.TabIndex = 6;
            // 
            // txtBoxpnBADGroup
            // 
            this.txtBoxpnBADGroup.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxpnBADGroup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.txtBoxpnBADGroup.Location = new System.Drawing.Point(83, 19);
            this.txtBoxpnBADGroup.Name = "txtBoxpnBADGroup";
            this.txtBoxpnBADGroup.Size = new System.Drawing.Size(466, 21);
            this.txtBoxpnBADGroup.TabIndex = 5;
            // 
            // lblAdGroup
            // 
            this.lblAdGroup.AutoSize = true;
            this.lblAdGroup.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdGroup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblAdGroup.Location = new System.Drawing.Point(7, 21);
            this.lblAdGroup.Name = "lblAdGroup";
            this.lblAdGroup.Size = new System.Drawing.Size(60, 15);
            this.lblAdGroup.TabIndex = 4;
            this.lblAdGroup.Text = "AD Group";
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.ColumnHeadersHeight = 25;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView.GridColor = System.Drawing.Color.LightGray;
            this.dataGridView.Location = new System.Drawing.Point(6, 87);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView.Size = new System.Drawing.Size(557, 335);
            this.dataGridView.TabIndex = 4;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Identity Reference";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Access Control Type";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "FileSystem Rights";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Is Inherited";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // btnApplyPermission
            // 
            this.btnApplyPermission.BackColor = System.Drawing.Color.White;
            this.btnApplyPermission.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnApplyPermission.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApplyPermission.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnApplyPermission.Location = new System.Drawing.Point(298, 450);
            this.btnApplyPermission.Name = "btnApplyPermission";
            this.btnApplyPermission.Size = new System.Drawing.Size(112, 23);
            this.btnApplyPermission.TabIndex = 22;
            this.btnApplyPermission.Text = "&Apply Permission";
            this.btnApplyPermission.UseVisualStyleBackColor = false;
            this.btnApplyPermission.Click += new System.EventHandler(this.btnApplyPermission_Click);
            // 
            // progressBarPermStats
            // 
            this.progressBarPermStats.Location = new System.Drawing.Point(417, 489);
            this.progressBarPermStats.Name = "progressBarPermStats";
            this.progressBarPermStats.Size = new System.Drawing.Size(154, 20);
            this.progressBarPermStats.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBarPermStats.TabIndex = 23;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(576, 510);
            this.Controls.Add(this.progressBarPermStats);
            this.Controls.Add(this.btnApplyPermission);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnUpdateAD);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.BtnNext);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelChild);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "mainForm";
            this.Text = "AD Groups Creator Internal Test Release Only";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.panelChild.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.ToolStripStatusLabel statusLbl;
        private System.Windows.Forms.Button btnUpdateAD;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Button BtnNext;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel panelChild;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblCurrentDC;
        private System.Windows.Forms.TextBox txtBoxRITM;
        private System.Windows.Forms.TextBox txtBoxTask;
        private System.Windows.Forms.Label lblRITM;
        private System.Windows.Forms.Label lblTask;
        private System.Windows.Forms.CheckBox chkboxPopulate;
        private System.Windows.Forms.ComboBox cmbBoxGrography;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxGroupName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblValidation;
        private System.Windows.Forms.TextBox txtBoxSuggestion;
        private System.Windows.Forms.TextBox txtBoxShare;
        private System.Windows.Forms.ComboBox cmbBoxPermissionLevel;
        private System.Windows.Forms.Label lblPermissionLevel;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox lstBoxPreview;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblShare;
        private System.Windows.Forms.TextBox txtBoxpnBShare;
        private System.Windows.Forms.TextBox txtBoxpnBADGroup;
        private System.Windows.Forms.Label lblAdGroup;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button btnApplyPermission;
        private System.Windows.Forms.ProgressBar progressBarPermStats;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}

