using EmployeeManagementApp.DAL;
using EmployeeManagementApp.Model;
using System;
using System.Web.UI;

namespace EmployeeManagementApp
{
    public partial class EmployeeManagement : Page
    {
        private readonly datalayer _dataLayer;
        private readonly EmployeeManagementApp.DAL.Interfaces.IEmployeeService _employeeService;

        public EmployeeManagement()
        {
            _dataLayer = new datalayer();
            _employeeService = new DAL.Services.EmployeeService(new DAL.Services.EmployeeRepository(new EmployeeManagementApp.DAL.EmployeeDbContext()));
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindGridView();
            }
        }

        private void BindGridView()
        {
            //write your code here
            throw new NotImplementedException();
        }

        protected void gv_SelectedIndexChanged(object sender, EventArgs e)
        {
            //write your code here
            throw new NotImplementedException();
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            //write your code here
            throw new NotImplementedException();
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            //write your code here
            throw new NotImplementedException();
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            //write your code here
            throw new NotImplementedException();
        }
    }
}
