using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WMS.CreateEditForms.Patient
{
    public partial class EditPatient : Treatment
    {
        public EditPatient(int id)
        {
            new EditPatient();

            // code to edit existing patient 
        }

        public EditPatient()
        {
            // generic components between edit/create patient forms

            InitializeComponent();

            patientDetailsTab.Text = "General Information";
            wardSelectionTab.Dispose();
            nurseSelectionTab.Dispose();
        }
    }
}
