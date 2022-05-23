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
    public partial class FrmSupplierAdd : Form
    {
        private ApiManager _apiManager;
        public FrmSupplierAdd()
        {
            _apiManager = new ApiManager();
            InitializeComponent();
        }

        private async void btnEkle_Click(object sender, EventArgs e)
        {
            Address address = new Address();
            address.City = txtCity.Text;
            address.Country = txtCountry.Text;


            Supplier supplier = new Supplier();
            supplier.CompanyName = txtCompanyName.Text;
            supplier.ContactName = txtContactName.Text;
            supplier.ContactTitle = txtContactTitle.Text;
            supplier.Address = address;

            await _apiManager.AddAsync<Supplier>(supplier);

            this.Hide();

            FrmSupplier form = new FrmSupplier();
            form.ShowDialog();
        }
    }
}
