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
    public partial class ManagerForm : Form
    {
        protected Match match;
        protected int id;
        protected DateTime date = DateTime.ParseExact("1/1/0001", "d/M/yyyy", null);

        public ManagerForm()
        {
            InitializeComponent();

            this.ActiveControl = searchTextBox;

        }

        protected void DeleteSelectedRow(DataGridView gridTable, String table, String unique_column)
        {

            if (gridTable.SelectedRows.Count > 0)
            {

                if (MessageBox.Show("Delete selected record?",
                    "Caution", MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Warning) == DialogResult.Cancel)
                {
                    return;
                }

                this.Cursor = Cursors.WaitCursor;



                foreach (DataGridViewRow item in gridTable.SelectedRows)
                {
                    id = (int)gridTable.SelectedRows[0].Cells[0].Value;
                    gridTable.Rows.RemoveAt(item.Index);
                }


                Program.api_db.Delete("DELETE FROM "+table+
                    " WHERE " + unique_column + " = '"+ id +"'");



                this.Cursor = Cursors.Default;

            } 
        }

        private void searchTextBox_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {

        }

        private void refreshButton_Click(object sender, EventArgs e)
        {

        }

        private void form_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            this.ActiveControl = searchTextBox;
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

    }
}
