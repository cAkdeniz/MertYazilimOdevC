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
    public partial class FrmShipper : Form
    {
        private ApiManager _apiManager;
        public FrmShipper()
        {
            _apiManager = new ApiManager();
            InitializeComponent();
        }

        private async void FrmShipper_Load(object sender, EventArgs e)
        {
            await FillArray();
        }

        private async Task FillArray()
        {
            var shippers = await _apiManager.GetAllAsync<Shipper>();
            foreach (var item in shippers)
            {
                dgwShipper.Rows.Add(item.Id, item.CompanyName, item.Phone);
            }
        }

        private void Clear()
        {
            txtCompanyName.Text = "";
            txtPhone.Text = "";
        }

        private void ClearDgw()
        {
            this.dgwShipper.Rows.Clear();
        }

        private void dgwShipper_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSil.Enabled = true;
            btnGuncelle.Enabled = true;

            lblId.Text = dgwShipper.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtCompanyName.Text = dgwShipper.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtPhone.Text = dgwShipper.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private async void btnGuncelle_Click(object sender, EventArgs e)
        {
            var shipper = await _apiManager.GetAsync<Shipper>(lblId.Text);
            shipper.CompanyName = txtCompanyName.Text;
            shipper.Phone = txtPhone.Text;

            await _apiManager.UpdateAsync<Shipper>(shipper, lblId.Text);

            btnSil.Enabled = false;
            btnGuncelle.Enabled = false;
            Clear();
            ClearDgw();
            await FillArray();
        }

        private async void btnSil_Click(object sender, EventArgs e)
        {
            await _apiManager.DeleteAsync<Shipper>(lblId.Text);

            btnSil.Enabled = false;
            btnGuncelle.Enabled = false;
            Clear();
            ClearDgw();
            await FillArray();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            this.Hide();

            FrmShipperAdd form = new FrmShipperAdd();
            form.ShowDialog();
        }
    }
}
