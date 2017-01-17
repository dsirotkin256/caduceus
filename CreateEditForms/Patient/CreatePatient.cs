using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMS.CreateEditForms.Patient;

namespace WMS
{
    public partial class CreatePatient : EditPatient
    {

        public CreatePatient()
        {
            // code to create new patient

            InitializeComponent();

            patientDetailsTab.Text = "General Information";
            wardSelectionTab.Dispose();
            nurseSelectionTab.Dispose();
            LoadProfilebutton.Dispose();
        }

    }
}
