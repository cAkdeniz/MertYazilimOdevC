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
    public partial class FrmSupplier : Form
    {
        private ApiManager _apiManager;
        public FrmSupplier()
        {
            _apiManager = new ApiManager();
            InitializeComponent();
        }

        private async Task FillArray()
        {
            var suppliers = await _apiManager.GetAllAsync<Supplier>();
            foreach (var item in suppliers)
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
            var supplier = await _apiManager.GetAsync<Supplier>(lblId.Text);
            supplier.CompanyName = txtCompanyName.Text;
            supplier.ContactName = txtContactName.Text;
            supplier.ContactTitle = txtContactTitle.Text;
            supplier.Address.City = txtCity.Text;
            supplier.Address.Country = txtCountry.Text;

            await _apiManager.UpdateAsync<Supplier>(supplier, lblId.Text);

            btnSil.Enabled = false;
            btnGuncelle.Enabled = false;
            Clear();
            ClearDgw();
            await FillArray();
        }

        private async void btnSil_Click(object sender, EventArgs e)
        {
            await _apiManager.DeleteAsync<Supplier>(lblId.Text);

            btnSil.Enabled = false;
            btnGuncelle.Enabled = false;
            Clear();
            ClearDgw();
            await FillArray();
        }

        private async void FrmSupplier_Load(object sender, EventArgs e)
        {
            await FillArray();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            this.Hide();

            FrmSupplierAdd form = new FrmSupplierAdd();
            form.ShowDialog();
        }
    }
}
