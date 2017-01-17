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
    public partial class WardManager : ManagerForm
    {
        public WardManager()
        {
            InitializeComponent();
            InitializeCustomComponent();
        }

        private void InitializeCustomComponent()
        {
            managerDataGridView.DataSource =
                Program.api_db.FillDataTable
                ("SELECT "+
                "id 'Ward ID',"+
                "name 'Description',"+
                "COUNT (patient_id) 'Total Patients',"+
                "COUNT (nurse_id) 'Total Nurses' "+
                "FROM ward "+
                "LEFT OUTER JOIN treatment ON ward.id = ward_id "+
                "GROUP BY id, name, patient_id, nurse_id;");

        }

        void searchTextBox_KeyDown(object sender, KeyEventArgs e)
        {

           // if (e.KeyCode == Keys.Enter)
           // {
                // start searching
                //this.Cursor = Cursors.WaitCursor;


                bool is_num = Int32.TryParse(searchTextBox.Text, out id);

                // replace pattern
                match = 
                    Regex.Match(searchTextBox.Text, 
                    @"\d{1,2}[/\-.]\d{1,2}[/\-.]\d{4}",
                    RegexOptions.IgnoreCase);

                if (match.Success) 
                    date = DateTime.ParseExact(searchTextBox.Text, "d/M/yyyy", null);
               
                // render found result to the table grid
            managerDataGridView.DataSource =
                Program.api_db.FillDataTable
                ("SELECT "+
                "id 'Ward ID',"+
                "name 'Description',"+
                "COUNT (patient_id) 'Total Patients',"+
                "COUNT (nurse_id) 'Total Nurses' "+
                "FROM ward "+
                "LEFT OUTER JOIN treatment ON ward.id = ward_id "+
                "WHERE id LIKE ('" + (is_num ? id : 0) + "%') OR " +
                "name LIKE ('" + searchTextBox.Text + "%')"+
                "GROUP BY id, name, patient_id, nurse_id ");


                //retrieving data succied
                //this.Cursor = Cursors.Default;
            //}

        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            InitializeCustomComponent();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DeleteSelectedRow(managerDataGridView, "ward", "id");
        }

        private void addButton_Click(object sender, EventArgs e)
        {

            Microsoft.VisualBasic.Interaction.InputBox("Enter the ward description: ", "Create Ward", "Default Text");
        }

    }
}
