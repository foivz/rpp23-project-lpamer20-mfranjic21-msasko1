using BusinessLogicLayer;
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
    public partial class FrmReservation : MaterialForm
    {
        public FrmReservation()
        {
            InitializeComponent();
        }
        MaterialSkinManager TManager = MaterialSkinManager.Instance;
        private void FrmReservation_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Theme == true)
                TManager.Theme = MaterialSkinManager.Themes.LIGHT;
            else
                TManager.Theme = MaterialSkinManager.Themes.DARK;

            LoadReservations();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var frmAddReservation = new FrmAddReservation(this);
            frmAddReservation.ShowDialog();
        }

        public void LoadReservations()
        {
            var reservationService = new ReservationService();

            var reservations = reservationService.GetReservations();

            dgvReservations.DataSource = reservations;
            dgvReservations.Columns["Customer"].Visible = false;
            dgvReservations.Columns["Vehicle"].Visible = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {

        }
    }
}
