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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Iznajmljivanje_Vozila.Forms
{
    public partial class FrmVehicleStatus : MaterialForm
    {
        public FrmVehicleStatus()
        {
            InitializeComponent();
        }

        MaterialSkinManager TManager = MaterialSkinManager.Instance;

        private void FrmVehicleStatus_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rPP2324_T13_DBDataSet.Reservation' table. You can move, or remove it, as needed.
            this.reservationTableAdapter.Fill(this.rPP2324_T13_DBDataSet.Reservation);
            // TODO: This line of code loads data into the 'rPP2324_T13_DBDataSet.Vehicle' table. You can move, or remove it, as needed.
            this.vehicleTableAdapter.Fill(this.rPP2324_T13_DBDataSet.Vehicle);

            if (Properties.Settings.Default.Theme == true)
                TManager.Theme = MaterialSkinManager.Themes.LIGHT;
            else
                TManager.Theme = MaterialSkinManager.Themes.DARK;

            LoadVehicles();
        }

        private void LoadVehicles()
        {
            var vehicleService = new VehicleService();

            List<Vehicle> vehicles = vehicleService.GetVehicles();

            dgvVehicles.DataSource = vehicles;
            dgvVehicles.Columns["Reservations"].Visible = false;
        }

        private void btnGetHistory_Click(object sender, EventArgs e)
        {
            var selectedCell = dgvVehicles.SelectedCells[0];

            if (selectedCell != null)
            {
                Vehicle selectedVehicle = (Vehicle)dgvVehicles.Rows[selectedCell.RowIndex].DataBoundItem;


                var reservationService = new ReservationService();
                var reservations = reservationService.GetReservationByVehicle(selectedVehicle.id);

                dgvReservationHistory.DataSource = reservations;
                dgvReservationHistory.Columns["Customer"].Visible = false;
                dgvReservationHistory.Columns["Vehicle"].Visible = false;

            }
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            
        }
    }
}
