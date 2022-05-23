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
    public partial class FrmCustomerAdd : Form
    {
        private ApiManager _apiManager;
        public FrmCustomerAdd()
        {
            _apiManager = new ApiManager();
            InitializeComponent();
        }

        private async void btnEkle_Click(object sender, EventArgs e)
        {
            Address address = new Address();
            address.City = txtCity.Text;
            address.Country = txtCountry.Text;


            Customer customer = new Customer();
            customer.CompanyName = txtCompanyName.Text;
            customer.ContactName = txtContactName.Text;
            customer.ContactTitle = txtContactTitle.Text;
            customer.Address = address;

            await _apiManager.AddAsync<Customer>(customer);

            this.Hide();

            FrmSupplier form = new FrmSupplier();
            form.ShowDialog();
        }
    }
}
