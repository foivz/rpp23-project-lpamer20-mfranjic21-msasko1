﻿using BusinessLogicLayer.Services;
using Iznajmljivanje_Vozila.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
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
    public partial class FrmLogin : MaterialForm
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        MaterialSkinManager TManager = MaterialSkinManager.Instance;
        private void frmLogin_Load(object sender, EventArgs e)
        {
            /*
            if (Properties.Settings.Default.Theme == true)
                TManager.Theme = MaterialSkinManager.Themes.LIGHT;
            else
                TManager.Theme = MaterialSkinManager.Themes.DARK;
            */
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            await PerformLogin();
        }

        private async Task PerformLogin()
        {
            var username = txtUsername.Text;
            var password = txtPassword.Text;

            var loginService = new LoginService();

            var login = await loginService.LoginUsernamePassword(username, password);

            if (login)
            {
                //MessageBox.Show("Uspješna prijava");
                this.Hide();
                FrmVehicleStatus frmVehicleStatus = new FrmVehicleStatus();
                frmVehicleStatus.Closed += (s, args) => this.Close(); 
                frmVehicleStatus.Show();
                
            }
            else
            {
                MessageBox.Show("Neuspješna prijava");
            }
        }

    }
}
