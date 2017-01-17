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
    public partial class NurseManager : ManagerForm
    {
        public NurseManager()
        {
            InitializeComponent();
            InitializeCustomComponent();
        }

        private void InitializeCustomComponent()
        {
            managerDataGridView.DataSource =
                Program.api_db.FillDataTable("SELECT " +
               "id AS 'Nurse ID'," +
               "f_name AS 'First Name'," +
               "l_name AS 'Last Name'," +
               "gender AS 'Gender'," +
               "birth_date AS 'Birth Date', " +
               "COUNT(patient_id) AS 'Total Patients'" +
               "FROM " +
               "nurse " +
               "LEFT OUTER JOIN treatment ON nurse.id = nurse_id "+
               "GROUP BY id,f_name,l_name,gender,birth_date;");
        }

        void searchTextBox_KeyDown(object sender, KeyEventArgs e)
        {

            //if (e.KeyCode == Keys.Enter)
            //{
                // start searching
                //this.Cursor = Cursors.WaitCursor;


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
                   "id AS 'Nurse ID'," +
                   "f_name AS 'First Name'," +
                   "l_name AS 'Last Name'," +
                   "gender AS 'Gender'," +
                   "birth_date AS 'Birth Date', " +
                   "COUNT(patient_id) AS 'Total Patinets'" +
                   "FROM " +
                   "nurse " +
                   "LEFT OUTER JOIN treatment ON nurse.id = nurse_id " +
                   "WHERE id LIKE ('" + (is_num ? id : 0) + "%') OR " +
                   "f_name LIKE ('" + searchTextBox.Text + "%') OR " +
                   "l_name LIKE ('" + searchTextBox.Text + "%') OR " +
                   "gender LIKE ('" + searchTextBox.Text + "%') OR " +
                   "birth_date ='" + date.ToString("d/M/yyyy") + "'"+
                   "GROUP BY id,f_name,l_name,gender,birth_date;");


                //retrieving data succied
                //this.Cursor = Cursors.Default;
           // }

        }


        private void deleteButton_Click(object sender, EventArgs e)
        {
            DeleteSelectedRow(this.managerDataGridView, "nurse", "id");
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            InitializeCustomComponent();
        }



    }
}
