using BusinessLogicLayer;
using BusinessLogicLayer.Services;
using EntitiesLayer.Entities;
using Iznajmljivanje_Vozila.Forms;
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

namespace Iznajmljivanje_Vozila
{
    public partial class FrmAnswerQuestion : MaterialForm
    {
        private SupportServices services = new SupportServices();
        private CustomerService customerService = new CustomerService();
        private Support answerSupport;

        public FrmAnswerQuestion(EntitiesLayer.Entities.Support support)
        {
            answerSupport = support;
            InitializeComponent();
        }

        MaterialSkinManager TManager = MaterialSkinManager.Instance;

        private void FrmAnswerQuestion_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Theme == true)
                TManager.Theme = MaterialSkinManager.Themes.LIGHT;
            else
                TManager.Theme = MaterialSkinManager.Themes.DARK;

            FillData();
        }

        private void FillData()
        {
            txtCustomer.Text = answerSupport.Customer.ToString();
            txtMessage.Text = answerSupport.message;
            txtMessageDate.Text = answerSupport.message_date.ToString();
        }

        private void btnSaveAnswer_Click(object sender, EventArgs e)
        {
            answerSupport.answer = mltAnswer.Text;
            answerSupport.Employee1 = LoggedUserService.GetLoggedUser();
            answerSupport.answer_date = DateTime.Today;

            services.UpdateQuestion(answerSupport);
            Close();
        }
    }
}
