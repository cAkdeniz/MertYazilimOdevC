using MertYazilim.Business.Abstract;
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
    public partial class FrmCategoryAdd : Form
    {
        private ApiManager _apiManager;
        public FrmCategoryAdd()
        {
            _apiManager = new ApiManager();
            InitializeComponent();
        }

        private async void btnEkle_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            category.Description = txtDescription.Text;
            category.Name = txtName.Text;

            await _apiManager.AddAsync<Category>(category);

            this.Hide();

            FrmCategory form = new FrmCategory();
            form.ShowDialog();
        }
    }
}
