using BusinessLogicLayer;
using EntitiesLayer.Entities;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Iznajmljivanje_Vozila.Forms
{
    public partial class frmVehicleManagement : MaterialForm
    {

        private VehicleServices services = new VehicleServices();

        public frmVehicleManagement()
        {
            InitializeComponent();
        }
        MaterialSkinManager TManager = MaterialSkinManager.Instance;
        private void frmVehicleManagement_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Theme == true)
                TManager.Theme = MaterialSkinManager.Themes.LIGHT;
            else
                TManager.Theme = MaterialSkinManager.Themes.DARK;

            DataGridView dataGridView = new DataGridView();

            ShowAllVehicles();


        }

        private void ShowAllVehicles()
        {
            var allVehicles = services.GetVehicles();
            dgvVehicleList.DataSource = allVehicles;
            dgvVehicleList.Columns["Reservations"].Visible = false;
        }

        private void vehicleBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.vehicleBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.rPP2324_T13_DBDataSet);

        }

        private void vehicleDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            frmNewVehicle forma = new frmNewVehicle();
            forma.ShowDialog();
            ShowAllVehicles();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var selectedVehicle = dgvVehicleList.CurrentRow.DataBoundItem as Vehicle;
            if (selectedVehicle != null)
            {
                services.RemoveVehicle(selectedVehicle);
                ShowAllVehicles();
            }
            else
            {

            }
        }
    }
}
