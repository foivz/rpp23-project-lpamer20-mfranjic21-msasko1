using BusinessLogicLayer;
using BusinessLogicLayer.Services;
using EntitiesLayer.Entities;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Iznajmljivanje_Vozila.Forms
{
    public partial class FrmMain : Form
    {
        MaterialSkinManager TManager = MaterialSkinManager.Instance;
        private Form currentForm;
        EmployeeService employeeService = new EmployeeService();

        private Panel panelButtons;

        public FrmMain(string username)
        {
            InitializeComponent();
            IsMdiContainer = true;

            LoggedUserService.Init(employeeService.GetEmployee(username));
            
            panelButtons = new Panel();
            panelButtons.Dock = DockStyle.Top;
            panelButtons.Height = 40;

            int buttonSpace = 5;
            int buttonPosition = buttonSpace;

            MaterialButton buttonFormReservations = new MaterialButton();
            buttonFormReservations.Text = "Rezervacije";
            buttonFormReservations.Click += btnReservations_Click;
            buttonFormReservations.Location = new System.Drawing.Point(buttonPosition, 0);
            panelButtons.Controls.Add(buttonFormReservations);

            buttonPosition += buttonFormReservations.Width + buttonSpace;

            MaterialButton buttonFormVehicleStatus = new MaterialButton();
            buttonFormVehicleStatus.Text = "Status vozila";
            buttonFormVehicleStatus.Click += btnVehicleStatus_Click;
            buttonFormVehicleStatus.Location = new System.Drawing.Point(buttonPosition, 0);
            panelButtons.Controls.Add(buttonFormVehicleStatus);

            buttonPosition += buttonFormVehicleStatus.Width + buttonSpace;

            MaterialButton buttonFormCustomerSupport = new MaterialButton();
            buttonFormCustomerSupport.Text = "Korisnička podrška";
            buttonFormCustomerSupport.Click += btnCustomerSupport_Click;
            buttonFormCustomerSupport.Location = new System.Drawing.Point(buttonPosition, 0);
            panelButtons.Controls.Add(buttonFormCustomerSupport);

            buttonPosition += buttonFormCustomerSupport.Width + buttonSpace;

            MaterialButton buttonFormCustomerMenagement = new MaterialButton();
            buttonFormCustomerMenagement.Text = "Upravljanje korisnicika";
            buttonFormCustomerMenagement.Click += btnCustomerMenagement_Click;
            buttonFormCustomerMenagement.Location = new System.Drawing.Point(buttonPosition, 0);
            panelButtons.Controls.Add(buttonFormCustomerMenagement);

            buttonPosition += buttonFormCustomerMenagement.Width + buttonSpace;

            MaterialButton buttonFormTransactionHistory = new MaterialButton();
            buttonFormTransactionHistory.Text = "Povijest transakcija";
            buttonFormTransactionHistory.Click += btnTransactionHistory_Click;
            buttonFormTransactionHistory.Location = new System.Drawing.Point(buttonPosition, 0);
            panelButtons.Controls.Add(buttonFormTransactionHistory);



            Controls.Add(panelButtons);
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Theme == true)
                TManager.Theme = MaterialSkinManager.Themes.LIGHT;
            else
                TManager.Theme = MaterialSkinManager.Themes.DARK;
        }

        private void ResizeForm()
        {
            if (ActiveMdiChild != null)
            {       
                ClientSize = new Size(ActiveMdiChild.Width + panelButtons.Height, ActiveMdiChild.Height + panelButtons.Height);
                //ClientSize = new Size(newForm.Width, newForm.Height);
            }
        }
        private void OpenForm(Form newForm)
        {
            if (currentForm != null && !currentForm.IsDisposed)
            {
                currentForm.Close();
            }

            

            currentForm = newForm;
            currentForm.MdiParent = this;

            currentForm.StartPosition = FormStartPosition.Manual;
            currentForm.Location = new Point(0, 0);

            currentForm.Show();
            ResizeForm();
           
        }

        private void btnReservations_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmReservation());
        }

        private void btnVehicleStatus_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmVehicleStatus());
        }

        private void btnCustomerSupport_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmCustomerSupport());
        }

        private void btnCustomerMenagement_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmCustomerManagement());
        }
        private void btnTransactionHistory_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmTransactionHistory());
        }
    }
}

