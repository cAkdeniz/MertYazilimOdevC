using MertYazilim.DesktopUI.ApiService;
using MertYazilim.Entities.Concrete.Log;
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
    public partial class FrmLog : Form
    {
        private ApiManager _apiManager;
        public FrmLog()
        {
            _apiManager = new ApiManager();
            InitializeComponent();
        }

        private async void FrmLog_Load(object sender, EventArgs e)
        {
            await FillArray();
        }

        private async Task FillArray()
        {
            var logs = await _apiManager.GetAllAsync<Log>();
            foreach (var item in logs)
            {
                dgwLog.Rows.Add(item.Id, item.Method, item.Path, item.Query, item.CreatedTime);
            }
        }
    }
}
