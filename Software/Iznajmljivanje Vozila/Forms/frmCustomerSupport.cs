using BusinessLogicLayer;
using EntitiesLayer.Entities;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Iznajmljivanje_Vozila.Forms
{
    public partial class FrmCustomerSupport : MaterialForm
    {

        private SupportServices services = new SupportServices();

        public FrmCustomerSupport()
        {
            InitializeComponent();
        }

        MaterialSkinManager TManager = MaterialSkinManager.Instance;
        private void frmCustomerSupport_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Theme == true)
                TManager.Theme = MaterialSkinManager.Themes.LIGHT;
            else
                TManager.Theme = MaterialSkinManager.Themes.DARK;

            ShowAllQuestions();
            FillCmbCategoryBy();
            EditDataGridView();
        }

        private void FillCmbCategoryBy()
        {
            cmbCategoryBy.Items.Clear();
            cmbCategoryBy.Items.Add("Odgovorenom");
            cmbCategoryBy.Items.Add("Korisniku");
            cmbCategoryBy.Items.Add("Zaposleniku");
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ShowAllQuestions();
        }

        private void ShowAllQuestions()
        {
            var allQuestions = services.GetQuestions();
            dgvCustomerSupport.DataSource = allQuestions;
        }


        private void EditDataGridView()
        {
            dgvCustomerSupport.Columns["id"].Visible = false;
            dgvCustomerSupport.Columns["user"].Visible = false;
            dgvCustomerSupport.Columns["employee"].Visible = false;

            dgvCustomerSupport.Columns["Customer"].HeaderText = "Korisnik";
            dgvCustomerSupport.Columns["Employee1"].HeaderText = "Zaposlenik";
            dgvCustomerSupport.Columns["message"].HeaderText = "Pitanje";
            dgvCustomerSupport.Columns["message_date"].HeaderText = "Datum pitanja";
            dgvCustomerSupport.Columns["answer"].HeaderText = "Odgovor";
            dgvCustomerSupport.Columns["answer_date"].HeaderText = "Datum odgovora";

        }

        private void btnRemoveQuestion_Click(object sender, EventArgs e)
        {
            try
            {
                Support support = dgvCustomerSupport.CurrentRow.DataBoundItem as Support;

                var services = new SupportServices();
                services.RemoveQuestion(support);

                ShowAllQuestions();
            } catch
            {
                MessageBox.Show("Odaberite red");
            }
        }

        private void btnAddNewQuestion_Click(object sender, EventArgs e)
        {
            var form = new FrmAddNewQuestion();
            form.ShowDialog();

            ShowAllQuestions();
        }

        private void cmbCategoryBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbSortBy.Enabled = true;
            if (cmbCategoryBy.Text == "Odgovorenom")
            {
                cmbSortBy.DropDownStyle = ComboBoxStyle.DropDownList;
                cmbSortBy.Items.Clear();
                cmbSortBy.Items.Add("Odgovoreno");
                cmbSortBy.Items.Add("Nije odgovoreno");
            } else
            {
                cmbSortBy.DropDownStyle = ComboBoxStyle.Simple;
                cmbSortBy.Items.Clear();
                cmbSortBy.Text = "";
            }
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            if (cmbCategoryBy.Text == "Korisniku")
            {
                SortByCustomer();
            } else if (cmbCategoryBy.Text == "Zaposleniku")
            {
                SortByEmployee();
            } else if (cmbCategoryBy.Text == "Odgovorenom")
            {
                SortByAnswered();
            } else
            {
                MessageBox.Show("Odaberite način sortiranja");
            }

        }

        private void SortByAnswered()
        {
            bool answered;
            if (cmbSortBy.Text == "Odgovoreno")
            {
                answered = true;
            } else if (cmbSortBy.Text == "Nije odgovoreno")
            {
                answered = false;
            } else
            {
                MessageBox.Show("Odaberite način sortiranja");
                return;
            }

            var sortedSupport = services.GetQuestionsIfAnswered(answered);
            dgvCustomerSupport.DataSource = sortedSupport;
        }

        private void SortByCustomer()
        {
            var customer = cmbSortBy.Text;
            var sortedSupport = services.GetQuestionsByCustomer(customer);
            dgvCustomerSupport.DataSource = sortedSupport;
        }

        private void SortByEmployee()
        {
            var employee = cmbSortBy.Text;
            var sortedSupport = services.GetQuestionsByEmployee(employee);
            dgvCustomerSupport.DataSource = sortedSupport;
        }

        private Support SelectedRow()
        {
            return dgvCustomerSupport.CurrentRow.DataBoundItem as Support;
        }

        private void btnAsnwerQuestion_Click(object sender, EventArgs e)
        {
            if (SelectedRow() != null)
            {
                var form = new FrmAnswerQuestion(SelectedRow());
                form.ShowDialog();

                ShowAllQuestions();
            } else
            {
                MessageBox.Show("Odaberite poruku");
            }

        }
    }
}
