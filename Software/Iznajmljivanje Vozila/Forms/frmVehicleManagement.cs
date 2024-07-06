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
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Iznajmljivanje_Vozila.Forms
{
    public partial class FrmVehicleManagement : MaterialForm
    {

        private VehicleService services = new VehicleService();

        public FrmVehicleManagement()
        {
            InitializeComponent();
        }
        MaterialSkinManager TManager = MaterialSkinManager.Instance;
        private void frmVehicleManagement_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rPP2324_T13_DBDataSet.Reservation' table. You can move, or remove it, as needed.
            this.reservationTableAdapter.Fill(this.rPP2324_T13_DBDataSet.Reservation);
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
            string columnNameToRemove = "Reservations";
            dgvVehicleList.Columns.Remove(columnNameToRemove);
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
            FrmNewVehicle forma = new FrmNewVehicle();
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

        private void btnPdf_Click(object sender, EventArgs e)
        {
            int columnCount = dgvVehicleList.ColumnCount, rowCount = dgvVehicleList.RowCount;
            List<string> items = new List<string>();
            List<string> headerText = new List<string>();

            foreach (DataGridViewRow dr in dgvVehicleList.Rows)
            {
                foreach (DataGridViewCell dc in dr.Cells)
                {
                    if (dc.Value != null)
                    {
                        items.Add(dc.Value.ToString());
                    } else
                    {
                        items.Add(" ");
                    }

                }
            }

            foreach (DataGridViewColumn dr in dgvVehicleList.Columns)
            {
                headerText.Add(dr.HeaderText);
            }

            new PdfService().PrintToPdf(columnCount, rowCount, items, headerText);
        }
    }
}
