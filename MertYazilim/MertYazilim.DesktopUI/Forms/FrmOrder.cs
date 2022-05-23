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
    public partial class FrmOrder : Form
    {
        private ApiManager _apiManager;
        public FrmOrder()
        {
            _apiManager = new ApiManager();
            InitializeComponent();
        }

        private async void FrmOrder_Load(object sender, EventArgs e)
        {
            await FillComboBox();
            await FillArray();
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

        private async Task FillArray()
        {
            var orders = await _apiManager.GetAllAsync<Order>();
            foreach (var item in orders)
            {
                dgwOrder.Rows.Add(item.Id, item.CustomerId, item.EmployeeId, item.ShipName, item.ShipVia, item.OrderDate,
                    item.RequiredDate, item.ShipAddress.City, item.ShipAddress.Country);
            }
        }

        private void Clear()
        {
            txtCustomer.Text = "";
            txtEmployee.Text = "";
            txtShipName.Text = "";
            txtShipVia.Text = "";
            txtCity.Text = "";
            txtCountry.Text = "";
        }

        private void ClearDgw()
        {
            this.dgwOrder.Rows.Clear();
        }

        private void dgwOrder_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSil.Enabled = true;
            btnGuncelle.Enabled = true;

            lblId.Text = dgwOrder.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtCustomer.Text = dgwOrder.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtEmployee.Text = dgwOrder.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtShipName.Text = dgwOrder.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtShipVia.Text = dgwOrder.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtCity.Text = dgwOrder.Rows[e.RowIndex].Cells[7].Value.ToString();
            txtCountry.Text = dgwOrder.Rows[e.RowIndex].Cells[8].Value.ToString();
        }

        private async void btnSil_Click(object sender, EventArgs e)
        {
            await _apiManager.DeleteAsync<Order>(lblId.Text);

            btnSil.Enabled = false;
            btnGuncelle.Enabled = false;
            Clear();
            ClearDgw();
            await FillArray();
        }

        private async void btnGuncelle_Click(object sender, EventArgs e)
        {
            var order = await _apiManager.GetAsync<Order>(lblId.Text);
            order.CustomerId = txtCustomer.Text;
            order.EmployeeId = Convert.ToInt32(txtEmployee.Text);
            order.ShipName = txtShipName.Text;
            order.ShipVia = txtShipVia.Text;
            order.ShipAddress.City = txtCity.Text;
            order.ShipAddress.Country = txtCountry.Text;

            await _apiManager.UpdateAsync<Order>(order, lblId.Text);

            btnSil.Enabled = false;
            btnGuncelle.Enabled = false;
            Clear();
            ClearDgw();
            await FillArray();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            this.Hide();

            FrmOrderAdd form = new FrmOrderAdd();
            form.ShowDialog();
        }
    }
}
