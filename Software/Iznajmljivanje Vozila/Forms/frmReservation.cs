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
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var frmAddReservation = new FrmAddReservation(this);
            frmAddReservation.ShowDialog();
        }
    }
}
