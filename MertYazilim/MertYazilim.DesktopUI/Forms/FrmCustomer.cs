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
    public partial class FrmCustomer : Form
    {
        private ApiManager _apiManager;
        public FrmCustomer()
        {
            _apiManager = new ApiManager();
            InitializeComponent();
        }

        private async Task FillArray()
        {
            var cutomers = await _apiManager.GetAllAsync<Customer>();
            foreach (var item in cutomers)
            {
                dgwSupplier.Rows.Add(item.Id, item.CompanyName, item.ContactName, item.ContactTitle, item.Address.City, item.Address.Country);
            }
        }

        private void Clear()
        {
            txtCompanyName.Text = "";
            txtContactName.Text = "";
            txtContactTitle.Text = "";
            txtCity.Text = "";
            txtCountry.Text = "";
        }

        private void ClearDgw()
        {
            this.dgwSupplier.Rows.Clear();
        }

        private async void FrmCustomer_Load(object sender, EventArgs e)
        {
            await FillArray();
        }

        private void dgwSupplier_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSil.Enabled = true;
            btnGuncelle.Enabled = true;

            lblId.Text = dgwSupplier.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtCompanyName.Text = dgwSupplier.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtContactName.Text = dgwSupplier.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtContactTitle.Text = dgwSupplier.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtCity.Text = dgwSupplier.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtCountry.Text = dgwSupplier.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private async void btnGuncelle_Click(object sender, EventArgs e)
        {
            var customer = await _apiManager.GetAsync<Customer>(lblId.Text);
            customer.CompanyName = txtCompanyName.Text;
            customer.ContactName = txtContactName.Text;
            customer.ContactTitle = txtContactTitle.Text;
            customer.Address.City = txtCity.Text;
            customer.Address.Country = txtCountry.Text;

            await _apiManager.UpdateAsync<Customer>(customer, lblId.Text);

            btnSil.Enabled = false;
            btnGuncelle.Enabled = false;
            Clear();
            ClearDgw();
            await FillArray();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            this.Hide();

            FrmCustomerAdd form = new FrmCustomerAdd();
            form.ShowDialog();
        }

        private async void btnSil_Click(object sender, EventArgs e)
        {
            await _apiManager.DeleteAsync<Customer>(lblId.Text);

            btnSil.Enabled = false;
            btnGuncelle.Enabled = false;
            Clear();
            ClearDgw();
            await FillArray();
        }
    }
}
