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
    public partial class FrmProductAdd : Form
    {
        private ApiManager _apiManager;
        public FrmProductAdd()
        {
            _apiManager = new ApiManager();
            InitializeComponent();
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

        private async void FrmProductAdd_Load(object sender, EventArgs e)
        {
            await FillComboBox();
        }

        private async void btnEkle_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.Name = txtName.Text;
            product.SupplierId = Convert.ToInt32(txtSupplierId.Text);
            product.CategoryId = Convert.ToInt32(txtCategoryId.Text);
            product.UnitPrice = Convert.ToDecimal(txtUnitPrice.Text);
            product.UnitsInStock = Convert.ToInt16(txtUnitsInStock.Text);
            product.QuantityPerUnit = txtQuantityPerUnit.Text;

            await _apiManager.AddAsync<Product>(product);

            this.Hide();

            FrmProduct form = new FrmProduct();
            form.ShowDialog();
        }
    }
}
