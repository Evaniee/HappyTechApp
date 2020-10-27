using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HappyTech
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            /*
             * Check Username = Password Consider using the following SQL Statement
             * SELECT COUNT(login_id) FROM logins WHERE username = 'whateverThey'reCalled' AND password = 'whateverTheItIs';
             * 
             * IF it returns 1 logged in
             * IF 0 not logged in
             * IF >1 not logged in multiple accounts under same name with same password, should consult database admins.
             */ 

        }
    }
}
