using BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Iznajmljivanje_Vozila
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var username = txtUsername.Text;
            var password = txtPassword.Text;

            var service = new LoginService();

            var login = service.LoginUsernamePassword(username, password);

            if (login)
            {
                MessageBox.Show("Uspjesna prijava");
            }
            else
            {
                MessageBox.Show("Neuspjesna prijava");
            }
        }
    }
}
