using MertYazilim.Business.Abstract;
using MertYazilim.DataAccess.Context.MssqlContext;
using MertYazilim.DesktopUI.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MertYazilim.DesktopUI
{
    public partial class FrmAnaSayfa : Form
    {
        public FrmAnaSayfa()
        {
            InitializeComponent();
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            FrmCategory form = new FrmCategory();
            form.ShowDialog();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            FrmCustomer form = new FrmCustomer();
            form.ShowDialog();
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            FrmEmployee form = new FrmEmployee();
            form.ShowDialog();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            FrmOrder form = new FrmOrder();
            form.ShowDialog();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            FrmProduct form = new FrmProduct();
            form.ShowDialog();
        }

        private void btnShipper_Click(object sender, EventArgs e)
        {
            FrmShipper form = new FrmShipper();
            form.ShowDialog();
        }

        private void btnSupplier_Click(object sender, EventArgs e)
        {
            FrmSupplier form = new FrmSupplier();
            form.ShowDialog();
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            FrmLog form = new FrmLog();
            form.ShowDialog();
        }
    }
}
