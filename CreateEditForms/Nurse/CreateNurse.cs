using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WMS.Create_Edit_user
{
    public partial class CreateNurse : EditNurse
    {
        public CreateNurse()
        {
            InitializeComponent();

            deleteButton.Dispose();
            this.Text = "Add Nurse";
        }

    }
}
