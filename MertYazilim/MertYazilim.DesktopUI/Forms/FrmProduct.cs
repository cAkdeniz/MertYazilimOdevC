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
    public partial class FrmProduct : Form
    {
        private ApiManager _apiManager;
        public FrmProduct()
        {
            _apiManager = new ApiManager();
            InitializeComponent();
        }

        private async void FrmProduct_Load(object sender, EventArgs e)
        {
            await FillComboBox();
            await FillArray();
        }

        private async Task FillComboBox()
        {
            var suppliers = await _apiManager.GetAllAsync<Supplier>();
            foreach (var item in suppliers)
            {
                txtSupplierId.Items.Add(item.Id);
            }

            var categories = await _apiManager.GetAllAsync<Category>();
            foreach (var item in categories)
            {
                txtCategoryId.Items.Add(item.Id);
            }
        }

        private async Task FillArray()
        {
            var products = await _apiManager.GetAllAsync<Product>();
            foreach (var item in products)
            {
                dgwProduct.Rows.Add(item.Id, item.Name, item.SupplierId, item.CategoryId, item.UnitPrice, item.QuantityPerUnit, item.UnitsInStock);
            }
        }

        private void ClearDgw()
        {
            this.dgwProduct.Rows.Clear();
        }

        private void Clear()
        {
            txtName.Text = "";
            txtSupplierId.Text = "";
            txtCategoryId.Text = "";
            txtUnitPrice.Text = "";
            txtUnitsInStock.Text = "";
            txtQuantityPerUnit.Text = "";
        }

        private void dgwProduct_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSil.Enabled = true;
            btnGuncelle.Enabled = true;

            lblId.Text = dgwProduct.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtName.Text = dgwProduct.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtSupplierId.Text = dgwProduct.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtCategoryId.Text = dgwProduct.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtUnitPrice.Text = dgwProduct.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtQuantityPerUnit.Text = dgwProduct.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtUnitsInStock.Text = dgwProduct.Rows[e.RowIndex].Cells[6].Value.ToString();
        }

        private async void btnSil_Click(object sender, EventArgs e)
        {
            await _apiManager.DeleteAsync<Product>(lblId.Text);

            btnSil.Enabled = false;
            btnGuncelle.Enabled = false;
            Clear();
            ClearDgw();
            await FillArray();
        }

        private async void btnGuncelle_Click(object sender, EventArgs e)
        {
            var product = await _apiManager.GetAsync<Product>(lblId.Text);
            product.Name = txtName.Text;
            product.SupplierId = Convert.ToInt32(txtSupplierId.Text);
            product.CategoryId = Convert.ToInt32(txtCategoryId.Text);
            product.UnitPrice = Convert.ToDecimal(txtUnitPrice.Text);
            product.QuantityPerUnit = txtQuantityPerUnit.Text;
            product.UnitsInStock = Convert.ToInt16(txtUnitsInStock.Text);

            await _apiManager.UpdateAsync<Product>(product, lblId.Text);

            btnSil.Enabled = false;
            btnGuncelle.Enabled = false;
            Clear();
            ClearDgw();
            await FillArray();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            this.Hide();

            FrmProductAdd form = new FrmProductAdd();
            form.ShowDialog();
        }
    }
}
