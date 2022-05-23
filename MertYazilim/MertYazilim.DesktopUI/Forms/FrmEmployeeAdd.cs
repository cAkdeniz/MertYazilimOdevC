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
    public partial class FrmEmployeeAdd : Form
    {
        private ApiManager _apiManager;
        public FrmEmployeeAdd()
        {
            _apiManager = new ApiManager();
            InitializeComponent();
        }

        private async void btnEkle_Click(object sender, EventArgs e)
        {
            Address address = new Address();
            address.City = txtCity.Text;
            address.Country = txtCountry.Text;


            Employee employee = new Employee();
            employee.FirstName = txtFirstName.Text;
            employee.LastName = txtLastName.Text;
            employee.Title = txtTitle.Text;
            employee.TitleOfCourtesy = txtTitleOfCourtesy.Text;
            employee.BirthDate = Convert.ToDateTime(txtBirthDate.Text);
            employee.HireDate = Convert.ToDateTime(txtHireDate.Text);
            employee.Notes = txtNotes.Text;
            employee.ReportsTo = txtReportsTo.Text;
            employee.Address = address;

            await _apiManager.AddAsync<Employee>(employee);

            this.Hide();

            FrmEmployee form = new FrmEmployee();
            form.ShowDialog();
        }
    }
}
