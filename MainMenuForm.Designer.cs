namespace WMS
{
    partial class MainMenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.addNewTreatmentButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.wardButton = new System.Windows.Forms.Button();
            this.createNurseButton = new System.Windows.Forms.Button();
            this.managePatientButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.addNewTreatmentButton, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 167F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 105F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 145F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(472, 439);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // addNewTreatmentButton
            // 
            this.addNewTreatmentButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.addNewTreatmentButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addNewTreatmentButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addNewTreatmentButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addNewTreatmentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewTreatmentButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.addNewTreatmentButton.Location = new System.Drawing.Point(4, 172);
            this.addNewTreatmentButton.Name = "addNewTreatmentButton";
            this.addNewTreatmentButton.Size = new System.Drawing.Size(464, 99);
            this.addNewTreatmentButton.TabIndex = 10;
            this.addNewTreatmentButton.Text = "Add new treatment";
            this.addNewTreatmentButton.UseVisualStyleBackColor = false;
            this.addNewTreatmentButton.Click += new System.EventHandler(this.addNewTreatmentButton_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::WMS.Properties.Resources.Heart;
            this.pictureBox1.Location = new System.Drawing.Point(4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(464, 161);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.57534F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.42466F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 146F));
            this.tableLayoutPanel2.Controls.Add(this.wardButton, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.createNurseButton, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.managePatientButton, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 278);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(464, 139);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // wardButton
            // 
            this.wardButton.BackColor = System.Drawing.Color.Teal;
            this.wardButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.wardButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wardButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.wardButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wardButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.wardButton.Location = new System.Drawing.Point(320, 3);
            this.wardButton.Name = "wardButton";
            this.wardButton.Size = new System.Drawing.Size(141, 133);
            this.wardButton.TabIndex = 11;
            this.wardButton.Text = "Wards";
            this.wardButton.UseVisualStyleBackColor = false;
            this.wardButton.Click += new System.EventHandler(this.wardButton_Click);
            // 
            // createNurseButton
            // 
            this.createNurseButton.BackColor = System.Drawing.Color.OrangeRed;
            this.createNurseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createNurseButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.createNurseButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.createNurseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createNurseButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.createNurseButton.Location = new System.Drawing.Point(151, 3);
            this.createNurseButton.Name = "createNurseButton";
            this.createNurseButton.Size = new System.Drawing.Size(163, 133);
            this.createNurseButton.TabIndex = 10;
            this.createNurseButton.Text = "Nurses";
            this.createNurseButton.UseVisualStyleBackColor = false;
            this.createNurseButton.Click += new System.EventHandler(this.createNurseButton_Click);
            // 
            // managePatientButton
            // 
            this.managePatientButton.BackColor = System.Drawing.Color.SeaGreen;
            this.managePatientButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.managePatientButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.managePatientButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.managePatientButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.managePatientButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.managePatientButton.Location = new System.Drawing.Point(3, 3);
            this.managePatientButton.Name = "managePatientButton";
            this.managePatientButton.Size = new System.Drawing.Size(142, 133);
            this.managePatientButton.TabIndex = 12;
            this.managePatientButton.Text = "Patients";
            this.managePatientButton.UseVisualStyleBackColor = false;
            this.managePatientButton.Click += new System.EventHandler(this.managePatientButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(472, 439);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hospital Management System";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button wardButton;
        private System.Windows.Forms.Button createNurseButton;
        private System.Windows.Forms.Button managePatientButton;
        private System.Windows.Forms.Button addNewTreatmentButton;

    }
}

