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
    public partial class FrmShipperAdd : Form
    {
        private ApiManager _apiManager;
        public FrmShipperAdd()
        {
            _apiManager = new ApiManager();
            InitializeComponent();
        }

        private async void btnEkle_Click(object sender, EventArgs e)
        {
            Shipper shipper = new Shipper();
            shipper.CompanyName = txtCompanyName.Text;
            shipper.Phone = txtPhone.Text;

            await _apiManager.AddAsync<Shipper>(shipper);

            this.Hide();

            FrmShipper form = new FrmShipper();
            form.ShowDialog();
        }
    }
}
