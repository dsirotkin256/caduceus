namespace WMS
{
    partial class Treatment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Treatment));
            this.TreatmentTabs = new System.Windows.Forms.TabControl();
            this.patientDetailsTab = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.criticalPatientGroupBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.shareRadioButton = new System.Windows.Forms.RadioButton();
            this.isolatedRadioButton = new System.Windows.Forms.RadioButton();
            this.isolationLabel = new System.Windows.Forms.Label();
            this.nextStepButton1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.genderPanel = new System.Windows.Forms.Panel();
            this.femaleRadioButton = new System.Windows.Forms.RadioButton();
            this.maleRadioButton = new System.Windows.Forms.RadioButton();
            this.avatarPictureBox = new System.Windows.Forms.PictureBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.genderLabel = new System.Windows.Forms.Label();
            this.dateBirthLabel = new System.Windows.Forms.Label();
            this.dateBirthDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.attachPhotoButton = new System.Windows.Forms.Button();
            this.LoadProfilebutton = new System.Windows.Forms.Button();
            this.criticalCheckBox = new System.Windows.Forms.CheckBox();
            this.wardSelectionTab = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.nextStepButton2 = new System.Windows.Forms.Button();
            this.wardDataGridView = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.complitionDateLabel = new System.Windows.Forms.Label();
            this.complitionDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.nurseSelectionTab = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.nurseDataGridView = new System.Windows.Forms.DataGridView();
            this.nextStepButton3 = new System.Windows.Forms.Button();
            this.TreatmentTabs.SuspendLayout();
            this.patientDetailsTab.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.criticalPatientGroupBox.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.genderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatarPictureBox)).BeginInit();
            this.tableLayoutPanel8.SuspendLayout();
            this.wardSelectionTab.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wardDataGridView)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.nurseSelectionTab.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nurseDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // TreatmentTabs
            // 
            this.TreatmentTabs.Controls.Add(this.patientDetailsTab);
            this.TreatmentTabs.Controls.Add(this.wardSelectionTab);
            this.TreatmentTabs.Controls.Add(this.nurseSelectionTab);
            this.TreatmentTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TreatmentTabs.ItemSize = new System.Drawing.Size(150, 30);
            this.TreatmentTabs.Location = new System.Drawing.Point(0, 0);
            this.TreatmentTabs.Name = "TreatmentTabs";
            this.TreatmentTabs.Padding = new System.Drawing.Point(11, 3);
            this.TreatmentTabs.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TreatmentTabs.SelectedIndex = 0;
            this.TreatmentTabs.Size = new System.Drawing.Size(329, 521);
            this.TreatmentTabs.TabIndex = 0;
            this.TreatmentTabs.SelectedIndexChanged += new System.EventHandler(this.TreatmentTabs_SelectedIndexChanged);
            // 
            // patientDetailsTab
            // 
            this.patientDetailsTab.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.patientDetailsTab.Controls.Add(this.tableLayoutPanel2);
            this.patientDetailsTab.Location = new System.Drawing.Point(4, 34);
            this.patientDetailsTab.Name = "patientDetailsTab";
            this.patientDetailsTab.Padding = new System.Windows.Forms.Padding(3);
            this.patientDetailsTab.Size = new System.Drawing.Size(321, 483);
            this.patientDetailsTab.TabIndex = 0;
            this.patientDetailsTab.Text = "1. General Information";
            this.patientDetailsTab.Click += new System.EventHandler(this.patientDetailsTab_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.criticalPatientGroupBox, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.nextStepButton1, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.criticalCheckBox, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.65385F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 61F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(315, 477);
            this.tableLayoutPanel2.TabIndex = 52;
            this.tableLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
            // 
            // criticalPatientGroupBox
            // 
            this.criticalPatientGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.criticalPatientGroupBox.Controls.Add(this.tableLayoutPanel6);
            this.criticalPatientGroupBox.Enabled = false;
            this.criticalPatientGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.criticalPatientGroupBox.ForeColor = System.Drawing.Color.DimGray;
            this.criticalPatientGroupBox.Location = new System.Drawing.Point(3, 363);
            this.criticalPatientGroupBox.Name = "criticalPatientGroupBox";
            this.criticalPatientGroupBox.Size = new System.Drawing.Size(309, 55);
            this.criticalPatientGroupBox.TabIndex = 57;
            this.criticalPatientGroupBox.TabStop = false;
            this.criticalPatientGroupBox.Text = "Additional Information";
            this.criticalPatientGroupBox.Enter += new System.EventHandler(this.criticalPatientGroupBox_Enter);
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.66667F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.33333F));
            this.tableLayoutPanel6.Controls.Add(this.tableLayoutPanel7, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.isolationLabel, 0, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.51515F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(303, 36);
            this.tableLayoutPanel6.TabIndex = 0;
            this.tableLayoutPanel6.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel6_Paint);
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 2;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Controls.Add(this.shareRadioButton, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.isolatedRadioButton, 0, 0);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(126, 3);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(174, 30);
            this.tableLayoutPanel7.TabIndex = 61;
            this.tableLayoutPanel7.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel7_Paint);
            // 
            // shareRadioButton
            // 
            this.shareRadioButton.AutoSize = true;
            this.shareRadioButton.Checked = true;
            this.shareRadioButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.shareRadioButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.shareRadioButton.Location = new System.Drawing.Point(90, 3);
            this.shareRadioButton.Name = "shareRadioButton";
            this.shareRadioButton.Size = new System.Drawing.Size(81, 24);
            this.shareRadioButton.TabIndex = 44;
            this.shareRadioButton.TabStop = true;
            this.shareRadioButton.Text = "Share";
            this.shareRadioButton.UseVisualStyleBackColor = true;
            this.shareRadioButton.CheckedChanged += new System.EventHandler(this.shareRadioButton_CheckedChanged);
            // 
            // isolatedRadioButton
            // 
            this.isolatedRadioButton.AutoSize = true;
            this.isolatedRadioButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.isolatedRadioButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.isolatedRadioButton.Location = new System.Drawing.Point(3, 3);
            this.isolatedRadioButton.Name = "isolatedRadioButton";
            this.isolatedRadioButton.Size = new System.Drawing.Size(81, 24);
            this.isolatedRadioButton.TabIndex = 43;
            this.isolatedRadioButton.Text = "Isolated";
            this.isolatedRadioButton.UseVisualStyleBackColor = true;
            this.isolatedRadioButton.CheckedChanged += new System.EventHandler(this.isolatedRadioButton_CheckedChanged);
            // 
            // isolationLabel
            // 
            this.isolationLabel.AutoSize = true;
            this.isolationLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.isolationLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.isolationLabel.Location = new System.Drawing.Point(3, 0);
            this.isolationLabel.Name = "isolationLabel";
            this.isolationLabel.Size = new System.Drawing.Size(117, 36);
            this.isolationLabel.TabIndex = 59;
            this.isolationLabel.Text = "Isolation status";
            this.isolationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.isolationLabel.Click += new System.EventHandler(this.isolationLabel_Click);
            // 
            // nextStepButton1
            // 
            this.nextStepButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nextStepButton1.BackColor = System.Drawing.Color.SteelBlue;
            this.nextStepButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nextStepButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextStepButton1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.nextStepButton1.Location = new System.Drawing.Point(3, 424);
            this.nextStepButton1.Name = "nextStepButton1";
            this.nextStepButton1.Size = new System.Drawing.Size(309, 50);
            this.nextStepButton1.TabIndex = 56;
            this.nextStepButton1.Text = "Next Step";
            this.nextStepButton1.UseVisualStyleBackColor = false;
            this.nextStepButton1.Click += new System.EventHandler(this.nextStepButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetPartial;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.79264F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.20736F));
            this.tableLayoutPanel1.Controls.Add(this.genderPanel, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.avatarPictureBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lastNameTextBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lastNameLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.firstNameLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.firstNameTextBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.genderLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.dateBirthLabel, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.dateBirthDateTimePicker, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel8, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 77.98742F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.01258F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(309, 294);
            this.tableLayoutPanel1.TabIndex = 52;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // genderPanel
            // 
            this.genderPanel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.genderPanel.Controls.Add(this.femaleRadioButton);
            this.genderPanel.Controls.Add(this.maleRadioButton);
            this.genderPanel.Location = new System.Drawing.Point(122, 213);
            this.genderPanel.Name = "genderPanel";
            this.genderPanel.Size = new System.Drawing.Size(144, 29);
            this.genderPanel.TabIndex = 49;
            this.genderPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.genderPanel_Paint);
            // 
            // femaleRadioButton
            // 
            this.femaleRadioButton.AutoSize = true;
            this.femaleRadioButton.Location = new System.Drawing.Point(72, 6);
            this.femaleRadioButton.Name = "femaleRadioButton";
            this.femaleRadioButton.Size = new System.Drawing.Size(59, 17);
            this.femaleRadioButton.TabIndex = 4;
            this.femaleRadioButton.Text = "Female";
            this.femaleRadioButton.UseVisualStyleBackColor = true;
            this.femaleRadioButton.CheckedChanged += new System.EventHandler(this.femaleRadioButton_CheckedChanged);
            // 
            // maleRadioButton
            // 
            this.maleRadioButton.AutoSize = true;
            this.maleRadioButton.Checked = true;
            this.maleRadioButton.Location = new System.Drawing.Point(11, 6);
            this.maleRadioButton.Name = "maleRadioButton";
            this.maleRadioButton.Size = new System.Drawing.Size(48, 17);
            this.maleRadioButton.TabIndex = 3;
            this.maleRadioButton.TabStop = true;
            this.maleRadioButton.Text = "Male";
            this.maleRadioButton.UseVisualStyleBackColor = true;
            this.maleRadioButton.CheckedChanged += new System.EventHandler(this.maleRadioButton_CheckedChanged);
            // 
            // avatarPictureBox
            // 
            this.avatarPictureBox.AccessibleName = "";
            this.avatarPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.avatarPictureBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.avatarPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.avatarPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.avatarPictureBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.avatarPictureBox.Image = global::WMS.Properties.Resources.contact_icon;
            this.avatarPictureBox.Location = new System.Drawing.Point(6, 6);
            this.avatarPictureBox.Name = "avatarPictureBox";
            this.avatarPictureBox.Size = new System.Drawing.Size(107, 122);
            this.avatarPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.avatarPictureBox.TabIndex = 29;
            this.avatarPictureBox.TabStop = false;
            this.avatarPictureBox.Tag = "";
            this.avatarPictureBox.Click += new System.EventHandler(this.avatarPictureBox_Click);
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.AccessibleName = "Last Name";
            this.lastNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lastNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lastNameTextBox.Location = new System.Drawing.Point(122, 180);
            this.lastNameTextBox.MaxLength = 30;
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(181, 20);
            this.lastNameTextBox.TabIndex = 47;
            this.lastNameTextBox.TextChanged += new System.EventHandler(this.lastNameTextBox_TextChanged);
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lastNameLabel.Location = new System.Drawing.Point(6, 173);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(107, 34);
            this.lastNameLabel.TabIndex = 48;
            this.lastNameLabel.Text = "Last Name";
            this.lastNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lastNameLabel.Click += new System.EventHandler(this.lastNameLabel_Click);
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.firstNameLabel.Location = new System.Drawing.Point(6, 134);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(107, 36);
            this.firstNameLabel.TabIndex = 32;
            this.firstNameLabel.Text = "First Name";
            this.firstNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.firstNameLabel.Click += new System.EventHandler(this.firstNameLabel_Click);
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.AccessibleName = "First Name";
            this.firstNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.firstNameTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.firstNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.firstNameTextBox.Location = new System.Drawing.Point(122, 142);
            this.firstNameTextBox.MaxLength = 30;
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(181, 20);
            this.firstNameTextBox.TabIndex = 31;
            this.firstNameTextBox.TextChanged += new System.EventHandler(this.firstNameTextBox_TextChanged);
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.genderLabel.Location = new System.Drawing.Point(6, 210);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(107, 35);
            this.genderLabel.TabIndex = 33;
            this.genderLabel.Text = "Gender";
            this.genderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.genderLabel.Click += new System.EventHandler(this.genderLabel_Click);
            // 
            // dateBirthLabel
            // 
            this.dateBirthLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateBirthLabel.Location = new System.Drawing.Point(6, 251);
            this.dateBirthLabel.Name = "dateBirthLabel";
            this.dateBirthLabel.Size = new System.Drawing.Size(106, 36);
            this.dateBirthLabel.TabIndex = 35;
            this.dateBirthLabel.Text = "Date of birth";
            this.dateBirthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dateBirthLabel.Click += new System.EventHandler(this.dateBirthLabel_Click);
            // 
            // dateBirthDateTimePicker
            // 
            this.dateBirthDateTimePicker.AllowDrop = true;
            this.dateBirthDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dateBirthDateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.dateBirthDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateBirthDateTimePicker.Location = new System.Drawing.Point(122, 259);
            this.dateBirthDateTimePicker.MaxDate = new System.DateTime(2014, 8, 8, 1, 30, 52, 247);
            this.dateBirthDateTimePicker.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateBirthDateTimePicker.Name = "dateBirthDateTimePicker";
            this.dateBirthDateTimePicker.Size = new System.Drawing.Size(97, 20);
            this.dateBirthDateTimePicker.TabIndex = 34;
            this.dateBirthDateTimePicker.Value = new System.DateTime(2014, 8, 8, 1, 30, 52, 247);
            this.dateBirthDateTimePicker.ValueChanged += new System.EventHandler(this.dateBirthDateTimePicker_ValueChanged);
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 1;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.Controls.Add(this.attachPhotoButton, 0, 1);
            this.tableLayoutPanel8.Controls.Add(this.LoadProfilebutton, 0, 0);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(122, 6);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 2;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65.57377F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.42623F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(181, 122);
            this.tableLayoutPanel8.TabIndex = 50;
            this.tableLayoutPanel8.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel8_Paint);
            // 
            // attachPhotoButton
            // 
            this.attachPhotoButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.attachPhotoButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.attachPhotoButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.attachPhotoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attachPhotoButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.attachPhotoButton.Location = new System.Drawing.Point(3, 82);
            this.attachPhotoButton.Name = "attachPhotoButton";
            this.attachPhotoButton.Size = new System.Drawing.Size(175, 37);
            this.attachPhotoButton.TabIndex = 33;
            this.attachPhotoButton.Text = "Attach Photo";
            this.attachPhotoButton.UseVisualStyleBackColor = false;
            this.attachPhotoButton.Click += new System.EventHandler(this.attachPhotoButton_Click);
            // 
            // LoadProfilebutton
            // 
            this.LoadProfilebutton.BackColor = System.Drawing.Color.Coral;
            this.LoadProfilebutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoadProfilebutton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoadProfilebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadProfilebutton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LoadProfilebutton.Location = new System.Drawing.Point(3, 3);
            this.LoadProfilebutton.Name = "LoadProfilebutton";
            this.LoadProfilebutton.Size = new System.Drawing.Size(175, 73);
            this.LoadProfilebutton.TabIndex = 32;
            this.LoadProfilebutton.Text = "Load existing profile";
            this.LoadProfilebutton.UseVisualStyleBackColor = false;
            this.LoadProfilebutton.Click += new System.EventHandler(this.LoadProfilebutton_Click);
            // 
            // criticalCheckBox
            // 
            this.criticalCheckBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.criticalCheckBox.Font = new System.Drawing.Font("Corbel", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.criticalCheckBox.ForeColor = System.Drawing.Color.DimGray;
            this.criticalCheckBox.Location = new System.Drawing.Point(35, 303);
            this.criticalCheckBox.Name = "criticalCheckBox";
            this.criticalCheckBox.Size = new System.Drawing.Size(245, 54);
            this.criticalCheckBox.TabIndex = 53;
            this.criticalCheckBox.Text = "* Check the box if the patient is in \r\ncritical condition";
            this.criticalCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.criticalCheckBox.UseVisualStyleBackColor = true;
            this.criticalCheckBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // wardSelectionTab
            // 
            this.wardSelectionTab.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.wardSelectionTab.Controls.Add(this.tableLayoutPanel5);
            this.wardSelectionTab.Location = new System.Drawing.Point(4, 34);
            this.wardSelectionTab.Name = "wardSelectionTab";
            this.wardSelectionTab.Padding = new System.Windows.Forms.Padding(3);
            this.wardSelectionTab.Size = new System.Drawing.Size(321, 483);
            this.wardSelectionTab.TabIndex = 1;
            this.wardSelectionTab.Text = "2. Choose Ward";
            this.wardSelectionTab.Click += new System.EventHandler(this.wardSelection_Click);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.nextStepButton2, 0, 2);
            this.tableLayoutPanel5.Controls.Add(this.wardDataGridView, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 3;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.30709F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 338F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(315, 477);
            this.tableLayoutPanel5.TabIndex = 53;
            this.tableLayoutPanel5.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel5_Paint);
            // 
            // nextStepButton2
            // 
            this.nextStepButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nextStepButton2.BackColor = System.Drawing.Color.SteelBlue;
            this.nextStepButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nextStepButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextStepButton2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.nextStepButton2.Location = new System.Drawing.Point(3, 425);
            this.nextStepButton2.Name = "nextStepButton2";
            this.nextStepButton2.Size = new System.Drawing.Size(309, 49);
            this.nextStepButton2.TabIndex = 58;
            this.nextStepButton2.Text = "Next Step";
            this.nextStepButton2.UseVisualStyleBackColor = false;
            this.nextStepButton2.Click += new System.EventHandler(this.nextStepButton2_Click);
            // 
            // wardDataGridView
            // 
            this.wardDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.wardDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.wardDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wardDataGridView.Location = new System.Drawing.Point(3, 87);
            this.wardDataGridView.Name = "wardDataGridView";
            this.wardDataGridView.Size = new System.Drawing.Size(309, 332);
            this.wardDataGridView.TabIndex = 57;
            this.wardDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.wardDataGridView_CellContentClick);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.7767F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.2233F));
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.complitionDateLabel, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.complitionDateTimePicker, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.dateTimePicker2, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(309, 78);
            this.tableLayoutPanel3.TabIndex = 56;
            this.tableLayoutPanel3.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel3_Paint);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 30);
            this.label1.TabIndex = 59;
            this.label1.Text = "Initiation of treatment";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // complitionDateLabel
            // 
            this.complitionDateLabel.Location = new System.Drawing.Point(3, 43);
            this.complitionDateLabel.Name = "complitionDateLabel";
            this.complitionDateLabel.Size = new System.Drawing.Size(120, 30);
            this.complitionDateLabel.TabIndex = 55;
            this.complitionDateLabel.Text = "Treatment completion";
            this.complitionDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.complitionDateLabel.Click += new System.EventHandler(this.complitionDateLabel_Click);
            // 
            // complitionDateTimePicker
            // 
            this.complitionDateTimePicker.AllowDrop = true;
            this.complitionDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.complitionDateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.complitionDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.complitionDateTimePicker.Location = new System.Drawing.Point(129, 50);
            this.complitionDateTimePicker.MaxDate = new System.DateTime(2020, 8, 8, 0, 0, 0, 0);
            this.complitionDateTimePicker.MinDate = new System.DateTime(2014, 8, 8, 1, 30, 52, 251);
            this.complitionDateTimePicker.Name = "complitionDateTimePicker";
            this.complitionDateTimePicker.Size = new System.Drawing.Size(177, 20);
            this.complitionDateTimePicker.TabIndex = 56;
            this.complitionDateTimePicker.Value = new System.DateTime(2014, 8, 8, 1, 30, 52, 251);
            this.complitionDateTimePicker.ValueChanged += new System.EventHandler(this.complitionDateTimePicker_ValueChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.AllowDrop = true;
            this.dateTimePicker2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker2.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(129, 11);
            this.dateTimePicker2.MaxDate = new System.DateTime(2020, 8, 8, 0, 0, 0, 0);
            this.dateTimePicker2.MinDate = new System.DateTime(2014, 8, 8, 1, 30, 52, 251);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(177, 20);
            this.dateTimePicker2.TabIndex = 58;
            this.dateTimePicker2.Value = new System.DateTime(2014, 8, 8, 1, 30, 52, 251);
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // nurseSelectionTab
            // 
            this.nurseSelectionTab.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.nurseSelectionTab.Controls.Add(this.tableLayoutPanel4);
            this.nurseSelectionTab.Location = new System.Drawing.Point(4, 34);
            this.nurseSelectionTab.Name = "nurseSelectionTab";
            this.nurseSelectionTab.Padding = new System.Windows.Forms.Padding(3);
            this.nurseSelectionTab.Size = new System.Drawing.Size(321, 483);
            this.nurseSelectionTab.TabIndex = 2;
            this.nurseSelectionTab.Text = "3. Assign Nurse";
            this.nurseSelectionTab.Click += new System.EventHandler(this.nurseSelectionTab_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.nurseDataGridView, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.nextStepButton3, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 421F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.20307F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(315, 477);
            this.tableLayoutPanel4.TabIndex = 0;
            this.tableLayoutPanel4.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel4_Paint);
            // 
            // nurseDataGridView
            // 
            this.nurseDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.nurseDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.nurseDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nurseDataGridView.Location = new System.Drawing.Point(3, 3);
            this.nurseDataGridView.Name = "nurseDataGridView";
            this.nurseDataGridView.Size = new System.Drawing.Size(309, 415);
            this.nurseDataGridView.TabIndex = 58;
            this.nurseDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.nurseDataGridView_CellContentClick);
            // 
            // nextStepButton3
            // 
            this.nextStepButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nextStepButton3.BackColor = System.Drawing.Color.DimGray;
            this.nextStepButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nextStepButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextStepButton3.ForeColor = System.Drawing.Color.White;
            this.nextStepButton3.Location = new System.Drawing.Point(3, 424);
            this.nextStepButton3.Name = "nextStepButton3";
            this.nextStepButton3.Size = new System.Drawing.Size(309, 50);
            this.nextStepButton3.TabIndex = 56;
            this.nextStepButton3.Text = "Submit Form";
            this.nextStepButton3.UseVisualStyleBackColor = false;
            this.nextStepButton3.Click += new System.EventHandler(this.nextStepButton3_Click);
            // 
            // Treatment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 521);
            this.Controls.Add(this.TreatmentTabs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Treatment";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add new treatment";
            this.Load += new System.EventHandler(this.ShowPatientsForm_Load);
            this.TreatmentTabs.ResumeLayout(false);
            this.patientDetailsTab.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.criticalPatientGroupBox.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.genderPanel.ResumeLayout(false);
            this.genderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatarPictureBox)).EndInit();
            this.tableLayoutPanel8.ResumeLayout(false);
            this.wardSelectionTab.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.wardDataGridView)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.nurseSelectionTab.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nurseDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.TabControl TreatmentTabs;
        protected System.Windows.Forms.TabPage patientDetailsTab;
        protected System.Windows.Forms.TabPage wardSelectionTab;
        protected System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        protected System.Windows.Forms.CheckBox criticalCheckBox;
        protected System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        protected System.Windows.Forms.PictureBox avatarPictureBox;
        protected System.Windows.Forms.Label lastNameLabel;
        protected System.Windows.Forms.Label firstNameLabel;
        protected System.Windows.Forms.Label genderLabel;
        protected System.Windows.Forms.Label dateBirthLabel;
        protected System.Windows.Forms.Panel genderPanel;
        protected System.Windows.Forms.RadioButton femaleRadioButton;
        protected System.Windows.Forms.RadioButton maleRadioButton;
        protected System.Windows.Forms.TextBox lastNameTextBox;
        protected System.Windows.Forms.TextBox firstNameTextBox;
        protected System.Windows.Forms.DateTimePicker dateBirthDateTimePicker;
        protected System.Windows.Forms.TabPage nurseSelectionTab;
        protected System.Windows.Forms.Button nextStepButton1;
        protected System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        protected System.Windows.Forms.Button nextStepButton2;
        protected System.Windows.Forms.DataGridView wardDataGridView;
        protected System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        protected System.Windows.Forms.Button nextStepButton3;
        protected System.Windows.Forms.DataGridView nurseDataGridView;
        protected System.Windows.Forms.GroupBox criticalPatientGroupBox;
        protected System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        protected System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        protected System.Windows.Forms.RadioButton shareRadioButton;
        protected System.Windows.Forms.RadioButton isolatedRadioButton;
        protected System.Windows.Forms.Label isolationLabel;
        protected System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        protected System.Windows.Forms.Label label1;
        protected System.Windows.Forms.Label complitionDateLabel;
        protected System.Windows.Forms.DateTimePicker complitionDateTimePicker;
        protected System.Windows.Forms.DateTimePicker dateTimePicker2;
        protected System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        protected System.Windows.Forms.Button LoadProfilebutton;
        protected System.Windows.Forms.Button attachPhotoButton;



    }
}