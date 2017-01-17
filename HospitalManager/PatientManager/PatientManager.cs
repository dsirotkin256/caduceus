using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace WMS
{
    public partial class PatientManager : ManagerForm
    {
        public PatientManager()
        {
            InitializeComponent();
            InitializeCustomComponent();
        }

        private void InitializeCustomComponent()
        {
            managerDataGridView.DataSource =
                Program.api_db.FillDataTable("SELECT " +
               "patient.id AS 'Patient ID'," +
               "patient.f_name AS 'First Name'," +
               "patient.l_name AS 'Last Name'," +
               "patient.gender AS 'Gender'," +
               "patient.birth_date AS 'Birth Date', " +
               "nurse.f_name +  nurse.l_name AS 'Nurse in charge', " +
               "nurse.id AS 'Nurse ID', " +
               "ward_id AS 'Ward ID' " +
               "FROM " +
               "patient " +
               "LEFT OUTER JOIN treatment ON patient.id = patient_id " +
               "LEFT OUTER JOIN nurse ON nurse.id = nurse_id " +
               "GROUP BY patient.id,patient.f_name,patient.l_name,patient.gender,"+
               "patient.birth_date,ward_id,nurse.f_name,nurse.l_name,nurse.id;");
        }

        void searchTextBox_KeyDown(object sender, KeyEventArgs e)
        {

           // if (e.KeyCode == Keys.Enter)
            //{
                // start searching
                this.Cursor = Cursors.WaitCursor;


                bool is_num = Int32.TryParse(searchTextBox.Text, out id);

                // replace pattern
                Match match =
                    Regex.Match(searchTextBox.Text,
                    @"\d{1,2}[/\-.]\d{1,2}[/\-.]\d{4}",
                    RegexOptions.IgnoreCase);

                if (match.Success)
                    date = DateTime.ParseExact(searchTextBox.Text, "d/M/yyyy", null);

                // render found result to the table grid
                managerDataGridView.DataSource =
                        Program.api_db.FillDataTable("SELECT " +
                   "patient.id AS 'Patient ID'," +
                   "patient.f_name AS 'First Name'," +
                   "patient.l_name AS 'Last Name'," +
                   "patient.gender AS 'Gender'," +
                   "patient.birth_date AS 'Birth Date', " +
                   "nurse.f_name + nurse.l_name AS 'Nurse in charge', " +
                   "nurse.id AS 'Nurse ID', "+
                   "ward_id AS 'Ward ID' " +
                   "FROM " +
                   "patient " +
                   "LEFT OUTER JOIN treatment ON patient.id = patient_id " +
                   "LEFT OUTER JOIN nurse ON nurse.id = nurse_id " +
                   "WHERE patient.id LIKE ('" + (is_num ? id : 0) + "%') OR " +
                   "patient.f_name LIKE ('" + searchTextBox.Text + "%') OR " +
                   "patient.l_name LIKE ('" + searchTextBox.Text + "%') OR " +
                   "patient.gender LIKE ('" + searchTextBox.Text + "%') OR " +
                   "patient.birth_date ='" + date.ToString("d/M/yyyy") + "' OR " +
                   "nurse_id LIKE ('" + (is_num ? id : 0) + "%') OR "+
                   "ward_id LIKE ('" + (is_num ? id : 0) + "%') OR "+
                   "nurse.f_name LIKE ('" + searchTextBox.Text + "%') OR " +
                   "nurse.l_name LIKE ('" + searchTextBox.Text + "%')" +
                   "GROUP BY patient.id,patient.f_name,patient.l_name,patient.gender," +
                   "patient.birth_date,ward_id,nurse.f_name,nurse.l_name,nurse.id;");


                //retrieving data succied
                this.Cursor = Cursors.Default;
            //}

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DeleteSelectedRow(this.managerDataGridView, "patient", "id");
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            InitializeCustomComponent();
        }

    }
}
