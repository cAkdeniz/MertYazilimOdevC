using MertYazilim.Business.Abstract;
using MertYazilim.DataAccess.Context.MssqlContext;
using MertYazilim.DesktopUI.ApiService;
using MertYazilim.Entities.Concrete;
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

namespace MertYazilim.DesktopUI.Forms
{
    public partial class FrmCategory : Form
    {
        private ApiManager _apiManager;
        public FrmCategory()
        {
            _apiManager = new ApiManager();
            InitializeComponent();
        }

        private async void FrmCategory_Load(object sender, EventArgs e)
        {
            await FillArray();
        }

        private async Task FillArray()
        {
            var categories = await _apiManager.GetAllAsync<Category>();
            foreach (var item in categories)
            {
                dgwCategory.Rows.Add(item.Id,item.Description, item.Name);
            }
        }

        private void Clear()
        {
            txtDescription.Text = "";
            txtName.Text = "";
        }

        private void dgwCategory_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSil.Enabled = true;
            btnGuncelle.Enabled = true;

            lblId.Text = dgwCategory.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtDescription.Text = dgwCategory.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtName.Text = dgwCategory.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private async void btnSil_Click(object sender, EventArgs e)
        {
            await _apiManager.DeleteAsync<Category>(lblId.Text);

            btnSil.Enabled = false;
            btnGuncelle.Enabled = false;
            Clear();
            ClearDgw();
            await FillArray();
        }

        private async void btnGuncelle_Click(object sender, EventArgs e)
        {
            var category = await _apiManager.GetAsync<Category>(lblId.Text);
            category.Description = txtDescription.Text;
            category.Name = txtName.Text;

            await _apiManager.UpdateAsync<Category>(category, lblId.Text);

            btnSil.Enabled = false;
            btnGuncelle.Enabled = false;
            Clear();
            ClearDgw();
            await FillArray();
        }

        private void ClearDgw()
        {
            this.dgwCategory.Rows.Clear();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            this.Hide();

            FrmCategoryAdd form = new FrmCategoryAdd();
            form.ShowDialog();
        }
    }
}
