using MertYazilim.DesktopUI.ApiService;
using MertYazilim.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MertYazilim.DesktopUI.Forms
{
    public partial class FrmEmployee : Form
    {
        private ApiManager _apiManager;
        public FrmEmployee()
        {
            _apiManager = new ApiManager();
            InitializeComponent();
        }

        private async Task FillArray()
        {
            var employess = await _apiManager.GetAllAsync<Employee>();
            foreach (var item in employess)
            {
                dgwEmployee.Rows.Add(item.Id, item.FirstName, item.LastName, item.Title, item.TitleOfCourtesy, item.BirthDate, item.HireDate,
                    item.Notes, item.ReportsTo, item.Address.City, item.Address.Country);
            }
        }

        private void Clear()
        {
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtTitle.Text = "";
            txtTitleOfCourtesy.Text = "";
            txtHireDate.Text = "";
            txtBirthDate.Text = "";
            txtNotes.Text = "";
            txtReportsTo.Text = "";
            txtCity.Text = "";
            txtCountry.Text = "";
        }

        private void ClearDgw()
        {
            this.dgwEmployee.Rows.Clear();
        }

        private async void FrmEmployee_Load(object sender, EventArgs e)
        {
            await FillArray();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            this.Hide();

            FrmEmployeeAdd form = new FrmEmployeeAdd();
            form.ShowDialog();
        }

        private async void btnGuncelle_Click(object sender, EventArgs e)
        {
            var employee = await _apiManager.GetAsync<Employee>(lblId.Text);
            employee.FirstName = txtFirstName.Text;
            employee.LastName = txtLastName.Text;
            employee.Title = txtTitle.Text;
            employee.Address.City = txtCity.Text;
            employee.Address.Country = txtCountry.Text;
            employee.Notes = txtNotes.Text;
            employee.ReportsTo = txtReportsTo.Text;
            employee.HireDate = Convert.ToDateTime(txtHireDate.Text);
            employee.BirthDate = Convert.ToDateTime(txtBirthDate.Text);

            await _apiManager.UpdateAsync<Employee>(employee, lblId.Text);

            btnSil.Enabled = false;
            btnGuncelle.Enabled = false;
            Clear();
            ClearDgw();
            await FillArray();
        }

        private async void btnSil_Click(object sender, EventArgs e)
        {
            await _apiManager.DeleteAsync<Employee>(lblId.Text);

            btnSil.Enabled = false;
            btnGuncelle.Enabled = false;
            Clear();
            ClearDgw();
            await FillArray();
        }

        private void dgwEmployee_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSil.Enabled = true;
            btnGuncelle.Enabled = true;

            lblId.Text = dgwEmployee.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtFirstName.Text = dgwEmployee.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtLastName.Text = dgwEmployee.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtTitle.Text = dgwEmployee.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtTitleOfCourtesy.Text = dgwEmployee.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtBirthDate.Text = dgwEmployee.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtHireDate.Text = dgwEmployee.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtNotes.Text = dgwEmployee.Rows[e.RowIndex].Cells[7].Value.ToString();
            txtReportsTo.Text = dgwEmployee.Rows[e.RowIndex].Cells[8].Value.ToString();
            txtCity.Text = dgwEmployee.Rows[e.RowIndex].Cells[9].Value.ToString();
            txtCountry.Text = dgwEmployee.Rows[e.RowIndex].Cells[10].Value.ToString();
        }
    }
}
