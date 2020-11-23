using HappyTech.BackEnd;
using HappyTech.BackEnd.FormBackEnds;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using HappyTech.FrontEnd;

namespace HappyTech
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
            Application.Run(new NewApplicant(new BackEnd.DatabaseClasses.JobPosition() { title = "Title", template_id = 1, description = "Desc", job_code = "Code0" }));
        }
    }
}
