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
    public partial class MainMenuForm : Form
    {

        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void wardButton_Click(object sender, EventArgs e)
        {

        }

        private void createNurseButton_Click(object sender, EventArgs e)
        {

        }

        private void managePatientButton_Click(object sender, EventArgs e)
        {

        }

        private void addNewTreatmentButton_Click_1(object sender, EventArgs e)
        {
            var form = new Treatment();
            form.ShowDialog();

        }
    }
}
