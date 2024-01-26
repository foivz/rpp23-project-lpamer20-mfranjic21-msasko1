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
    public partial class frmVehicleManagement : MaterialForm
    {
        public frmVehicleManagement()
        {
            InitializeComponent();
        }
        MaterialSkinManager TManager = MaterialSkinManager.Instance;
        private void frmVehicleManagement_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rPP2324_T13_DBDataSet.Vehicle' table. You can move, or remove it, as needed.
            this.vehicleTableAdapter.Fill(this.rPP2324_T13_DBDataSet.Vehicle);
            if (Properties.Settings.Default.Theme == true)
                TManager.Theme = MaterialSkinManager.Themes.LIGHT;
            else
                TManager.Theme = MaterialSkinManager.Themes.DARK;
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

        }
    }
}
