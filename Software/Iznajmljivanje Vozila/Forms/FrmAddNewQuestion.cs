using BusinessLogicLayer;
using EntitiesLayer.Entities;
using MaterialSkin;
using MaterialSkin.Controls;
using System;

namespace Iznajmljivanje_Vozila.Forms
{
    public partial class FrmAddNewQuestion : MaterialForm
    {
        private SupportServices services = new SupportServices();
        private CustomerService customerServices = new CustomerService();

        public FrmAddNewQuestion()
        {
            InitializeComponent();
        }

        MaterialSkinManager TManager = MaterialSkinManager.Instance;

        private void FrmAddNewQuestion_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Theme)
                TManager.Theme = MaterialSkinManager.Themes.LIGHT;
            else
                TManager.Theme = MaterialSkinManager.Themes.DARK;

            FillComboBox();
        }

        private void FillComboBox()
        {
            var allCustomers = customerServices.GetCustomersFullName();
            cmbUserList.DataSource = allCustomers;
        }

        private void btnAddNewQuestion_Click(object sender, EventArgs e)
        {
            var support = new Support
            {
                user = customerServices.GetCustomerByName(cmbUserList.Text).id,
                Customer = customerServices.GetCustomerByName(cmbUserList.Text),
                message = mltQuestionInput.Text,
                message_date = DateTime.Today
            };

            services.AddQuestion(support);
            Close();
        }
    }
}
