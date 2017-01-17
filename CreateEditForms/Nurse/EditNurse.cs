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
    public partial class EditNurse : Form
    {
        public EditNurse(int id)
        {
            new EditNurse();

            // code to edit existing nurse
        }

        public EditNurse()
        {
            InitializeComponent();
            
            // generic components between edit/create nurse forms
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

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
