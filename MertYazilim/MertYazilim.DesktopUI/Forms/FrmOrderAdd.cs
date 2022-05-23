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
    public partial class FrmOrderAdd : Form
    {
        private ApiManager _apiManager;
        public FrmOrderAdd()
        {
            _apiManager = new ApiManager();
            InitializeComponent();
        }

        private async void btnEkle_Click(object sender, EventArgs e)
        {
            ShipAddress shipAddress = new ShipAddress();
            shipAddress.City = txtCity.Text;
            shipAddress.Country = txtCountry.Text;

            Order order = new Order();
            order.CustomerId = txtCustomer.Text;
            order.EmployeeId = Convert.ToInt32(txtEmployee.Text);
            order.ShipName = txtShipName.Text;
            order.ShipVia = txtShipVia.Text;
            order.OrderDate = Convert.ToDateTime(txtOrderDate.Text);
            order.RequiredDate = Convert.ToDateTime(txtRequiredDate.Text);
            order.ShipAddress = shipAddress;

            await _apiManager.AddAsync<Order>(order);

            this.Hide();

            FrmOrder form = new FrmOrder();
            form.ShowDialog();
        }

        private async Task FillComboBox()
        {
            var customers = await _apiManager.GetAllAsync<Customer>();
            foreach (var item in customers)
            {
                txtCustomer.Items.Add(item.Id);
            }

            var employess = await _apiManager.GetAllAsync<Employee>();
            foreach (var item in employess)
            {
                txtEmployee.Items.Add(item.Id);
            }
        }

        private async void FrmOrderAdd_Load(object sender, EventArgs e)
        {
            await FillComboBox();
        }
    }
}
