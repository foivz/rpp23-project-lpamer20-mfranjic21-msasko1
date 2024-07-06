using BusinessLogicLayer;
using BusinessLogicLayer.Services;
using EntitiesLayer.Entities;
using MaterialSkin;
using MaterialSkin.Controls;
using Org.BouncyCastle.Ocsp;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Iznajmljivanje_Vozila.Forms
{
    public partial class FrmTransactionHistory : MaterialForm
    {
        private ReservationService services = new ReservationService();
        public FrmTransactionHistory()
        {
            InitializeComponent();
        }
        MaterialSkinManager TManager = MaterialSkinManager.Instance;
        private void frmTransactionHistory_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Theme)
                TManager.Theme = MaterialSkinManager.Themes.LIGHT;
            else
                TManager.Theme = MaterialSkinManager.Themes.DARK;

            FillCmbSortByData();
            ShowAllReservations();
        }

        private void ShowAllReservations()
        {
            var allReservations = services.GetReservations();

            FillDataGridViewData(allReservations);
        }

        private void FillDataGridViewData(List<Reservation> reservation)
        {
            reservation = services.ReplaceIDs(reservation);

            dgvTransactionHistory.DataSource = reservation;

            dgvTransactionHistory.Columns["id"].Visible = false;
            dgvTransactionHistory.Columns["customerId"].Visible = false;
            dgvTransactionHistory.Columns["vehicleId"].Visible = false;
            dgvTransactionHistory.Columns["pickupDate"].Visible = false;
            dgvTransactionHistory.Columns["returnDate"].Visible = false;
            dgvTransactionHistory.Columns["pickupLocation"].Visible = false;
            dgvTransactionHistory.Columns["returnLocation"].Visible = false;

            dgvTransactionHistory.Columns["totalCost"].HeaderText = "Ukupna cijena";
            dgvTransactionHistory.Columns["creationDate"].HeaderText = "Datum kreiranja";
            dgvTransactionHistory.Columns["status"].HeaderText = "Status";
            dgvTransactionHistory.Columns["Vehicle"].HeaderText = "Vozilo";
            dgvTransactionHistory.Columns["Customer"].HeaderText = "Korisnik";
        }

        private void FillCmbSortByData()
        {
            cmbSortBy.Items.Add("Korisniku");
            cmbSortBy.Items.Add("Vozilu");
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            if (cmbSortBy.Text == "Korisniku") {
                SortByCustomer();
            } else {
                SortByVehicle();
            }
        }

        private void SortByVehicle()
        {
            try
            {
                Reservation reservation = dgvTransactionHistory.CurrentRow.DataBoundItem as Reservation;
                var sortedCustomers = services.GetReservationByVehicle(reservation.vehicleID);
                FillDataGridViewData(sortedCustomers);
            } catch
            {
                MessageBox.Show("Odaberite red");
            }
        }

        private void SortByCustomer()
        {
            try { 
                Reservation reservation = dgvTransactionHistory.CurrentRow.DataBoundItem as Reservation;
                var sortedCustomers = services.GetReservationByCustomer(reservation.customerID);
                FillDataGridViewData(sortedCustomers);
            } catch
            {
                MessageBox.Show("Odaberite red");
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ShowAllReservations();
        }

        private void btnCreateReceipe_Click(object sender, EventArgs e)
        {
            try
            {
                Reservation reservation = dgvTransactionHistory.CurrentRow.DataBoundItem as Reservation;
                var form = new FrmReservationRecipe(reservation);
                form.ShowDialog();
            } catch
            {
                MessageBox.Show("Odaberite red");
            }
        }

        private void btnCreateReport_Click(object sender, EventArgs e)
        {
            DataGridView dgvForPdfPrint = dgvTransactionHistory;

            dgvForPdfPrint.Columns.Remove("customerId");
            dgvForPdfPrint.Columns.Remove("vehicleId");
            dgvForPdfPrint.Columns["id"].HeaderText = "ID transakcije";
            dgvForPdfPrint.Columns["pickupDate"].HeaderText = "Datum preuzimanja";
            dgvForPdfPrint.Columns["returnDate"].HeaderText = "Datum povratka";
            dgvForPdfPrint.Columns["pickupLocation"].HeaderText = "Mjesto preuzimanja";
            dgvForPdfPrint.Columns["returnLocation"].HeaderText = "mjesto povratka";

            int columnCount = dgvForPdfPrint.ColumnCount, rowCount = dgvForPdfPrint.RowCount;
            List<string> items = new List<string>();
            List<string> headerText = new List<string>();

            foreach (DataGridViewRow dr in dgvForPdfPrint.Rows)
            {
                foreach (DataGridViewCell dc in dr.Cells)
                {
                    if(dc.Value != null)
                    {
                        items.Add(dc.Value.ToString());
                    } else
                    {
                        items.Add(" ");
                    }
                    
                }
            }

            foreach (DataGridViewColumn dr in dgvForPdfPrint.Columns)
            {
                headerText.Add(dr.HeaderText);
            }

            new PdfService().PrintToPdf(columnCount, rowCount, items, headerText, true);
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            Reservation reservation = dgvTransactionHistory.CurrentRow.DataBoundItem as Reservation;

            var form = new FrmAddReservation(true, reservation);
            form.ShowDialog();
        }
    }
}
