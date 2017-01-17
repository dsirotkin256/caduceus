namespace WMS
{
    partial class ManagerForm
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

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.refreshButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.deleteButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.managerDataGridView = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.searchPictureBox = new System.Windows.Forms.PictureBox();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.managerDataGridView)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel5, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.managerDataGridView, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.70588F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.29412F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 106F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(646, 530);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.form_PreviewKeyDown);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(426, 406);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.label2.Size = new System.Drawing.Size(217, 13);
            this.label2.TabIndex = 91;
            this.label2.Text = "* Press double click to view in more details";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.form_PreviewKeyDown);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel5.Controls.Add(this.refreshButton, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel6, 1, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 426);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(640, 101);
            this.tableLayoutPanel5.TabIndex = 90;
            this.tableLayoutPanel5.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.form_PreviewKeyDown);
            // 
            // refreshButton
            // 
            this.refreshButton.BackColor = System.Drawing.Color.YellowGreen;
            this.refreshButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refreshButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.refreshButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.refreshButton.Image = global::WMS.Properties.Resources.refresh;
            this.refreshButton.Location = new System.Drawing.Point(3, 3);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(90, 95);
            this.refreshButton.TabIndex = 89;
            this.refreshButton.Text = "R";
            this.refreshButton.UseVisualStyleBackColor = false;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            this.refreshButton.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.form_PreviewKeyDown);
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.deleteButton, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.addButton, 0, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(99, 3);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.52632F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.47368F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(538, 95);
            this.tableLayoutPanel6.TabIndex = 86;
            this.tableLayoutPanel6.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.form_PreviewKeyDown);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.Tomato;
            this.deleteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.ForeColor = System.Drawing.Color.White;
            this.deleteButton.Location = new System.Drawing.Point(3, 51);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(532, 41);
            this.deleteButton.TabIndex = 89;
            this.deleteButton.Text = "Delete <entity>";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            this.deleteButton.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.form_PreviewKeyDown);
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.SteelBlue;
            this.addButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.addButton.Location = new System.Drawing.Point(3, 3);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(532, 42);
            this.addButton.TabIndex = 88;
            this.addButton.Text = "Add <entity>";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            this.addButton.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.form_PreviewKeyDown);
            // 
            // managerDataGridView
            // 
            this.managerDataGridView.AllowDrop = true;
            this.managerDataGridView.AllowUserToAddRows = false;
            this.managerDataGridView.AllowUserToDeleteRows = false;
            this.managerDataGridView.AllowUserToResizeColumns = false;
            this.managerDataGridView.AllowUserToResizeRows = false;
            this.managerDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.managerDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.managerDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.managerDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.managerDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.managerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.NullValue = "N/A";
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.managerDataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.managerDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.managerDataGridView.GridColor = System.Drawing.Color.White;
            this.managerDataGridView.Location = new System.Drawing.Point(3, 70);
            this.managerDataGridView.MultiSelect = false;
            this.managerDataGridView.Name = "managerDataGridView";
            this.managerDataGridView.ReadOnly = true;
            this.managerDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.managerDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.managerDataGridView.Size = new System.Drawing.Size(640, 329);
            this.managerDataGridView.TabIndex = 0;
            this.managerDataGridView.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.form_PreviewKeyDown);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.67797F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 578F));
            this.tableLayoutPanel2.Controls.Add(this.searchPictureBox, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.searchTextBox, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(640, 61);
            this.tableLayoutPanel2.TabIndex = 2;
            this.tableLayoutPanel2.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.form_PreviewKeyDown);
            // 
            // searchPictureBox
            // 
            this.searchPictureBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.searchPictureBox.Location = new System.Drawing.Point(3, 9);
            this.searchPictureBox.Name = "searchPictureBox";
            this.searchPictureBox.Size = new System.Drawing.Size(56, 43);
            this.searchPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.searchPictureBox.TabIndex = 2;
            this.searchPictureBox.TabStop = false;
            this.searchPictureBox.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.form_PreviewKeyDown);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.searchTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTextBox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.searchTextBox.Location = new System.Drawing.Point(65, 10);
            this.searchTextBox.MaxLength = 30;
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.searchTextBox.Size = new System.Drawing.Size(572, 40);
            this.searchTextBox.TabIndex = 1;
            this.searchTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchTextBox_KeyDown);
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(646, 530);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ManagerForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "List of <entity>";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.managerDataGridView)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        protected System.Windows.Forms.Label label2;
        protected System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        protected System.Windows.Forms.Button refreshButton;
        protected System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        protected System.Windows.Forms.Button deleteButton;
        protected System.Windows.Forms.Button addButton;
        protected System.Windows.Forms.TextBox searchTextBox;
        protected System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        protected System.Windows.Forms.PictureBox searchPictureBox;
        protected System.Windows.Forms.DataGridView managerDataGridView;


    }
}