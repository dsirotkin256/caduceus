using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMS.Create_Edit_user;
using WMS.CreateEditForms.Patient;

namespace WMS
{
    static class Program
    {
        public static Database_API.API_DB api_db = new Database_API.API_DB(false);

        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new WardManager());
            api_db.Close();
        }

    }
}
