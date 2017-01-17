using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WMS
{
    public partial class Treatment : Form
    {
        public static DataTable table = new DataTable();

        public Treatment()
        {
            InitializeComponent();
        }

        private void ShowPatientsForm_Load(object sender, EventArgs e)
        {

            table = GetPatientList();

        }

        private DataTable GetPatientList()
        {
            var table = new DataTable();



            return table;
        }

        private void generalInformationGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void wardSelection_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void nextStepButton_Click(object sender, EventArgs e)
        {
            TreatmentTabs.SelectTab(wardSelectionTab);
        }

        private void nextStepButton2_Click(object sender, EventArgs e)
        {
            TreatmentTabs.SelectTab(nurseSelectionTab);
        }

        private void nextStepButton3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The record was successfully created!");
            this.Close();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TreatmentTabs_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void patientDetailsTab_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void criticalPatientGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void shareRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void isolatedRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void isolationLabel_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void genderPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void femaleRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void maleRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void avatarPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void lastNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void lastNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void firstNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void firstNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void genderLabel_Click(object sender, EventArgs e)
        {

        }

        private void dateBirthLabel_Click(object sender, EventArgs e)
        {

        }

        private void dateBirthDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void attachPhotoButton_Click(object sender, EventArgs e)
        {

        }

        private void LoadProfilebutton_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void wardDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void complitionDateLabel_Click(object sender, EventArgs e)
        {

        }

        private void complitionDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void nurseSelectionTab_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void nurseDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
