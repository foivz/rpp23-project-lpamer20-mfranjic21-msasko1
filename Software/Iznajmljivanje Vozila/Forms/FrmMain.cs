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

        private Panel panelButtons;

        public FrmMain()
        {
            InitializeComponent();
            IsMdiContainer = true;

            
            panelButtons = new Panel();
            panelButtons.Dock = DockStyle.Top;
            panelButtons.Height = 40;
            

            MaterialButton buttonFormReservations = new MaterialButton();
            buttonFormReservations.Text = "Rezervacije";
            buttonFormReservations.Click += btnReservations_Click;
            panelButtons.Controls.Add(buttonFormReservations);
            
            MaterialButton buttonFormVehicleStatus = new MaterialButton();
            buttonFormVehicleStatus.Text = "Status vozila";
            buttonFormVehicleStatus.Click += btnVehicleStatus_Click;
            buttonFormVehicleStatus.Location = new System.Drawing.Point(120, 0);
            panelButtons.Controls.Add(buttonFormVehicleStatus);

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
    }
}
