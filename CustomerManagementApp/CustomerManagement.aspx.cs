using CustomerManagementApp.DAL;
using CustomerManagementApp.Model;
using System;
using System.Web.UI;

namespace CustomerManagementApp
{
    public partial class CustomerManagement : Page
    {
        private readonly datalayer _dataLayer;
        private readonly CustomerManagementApp.DAL.Interfaces.ICustomerService _customerService;

        public CustomerManagement()
        {
            _dataLayer = new datalayer();
            _customerService = new DAL.Services.CustomerService(new DAL.Services.CustomerRepository(new CustomerManagementApp.DAL.CustomerDbContext()));
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
            var customers = _customerService.GetAll();
            _dataLayer.fillgridView(customers, gv);
        }

        protected void gv_SelectedIndexChanged(object sender, EventArgs e)
        {
            var id = gv.SelectedRow.Cells[1].Text;
            // Retrieve the customer details and populate the form
            var customer = _customerService.GetById(id);
            if (customer != null)
            {
                txtFirstName.Text = customer.FirstName;
                txtLastName.Text = customer.LastName;
                txtDateOfBirth.Text = customer.DateOfBirth.ToString("yyyy-MM-dd");
            }
        }

        protected void btnsave_Click(object sender, EventArgs e)
        {
            var newCustomer = new CustomerModel
            {
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                DateOfBirth = DateTime.Parse(txtDateOfBirth.Text)
            };

            _customerService.Add();
            BindGridView();
        }

        protected void btnupdate_Click(object sender, EventArgs e)
        {
            string id = gv.SelectedRow.Cells[1].Text.ToString();
            var existingCustomer = _customerService.GetById(id);

            if (existingCustomer != null)
            {
                existingCustomer.LastName = txtLastName.Text;
                existingCustomer.FirstName = txtFirstName.Text;
                existingCustomer.DateOfBirth = DateTime.Parse(txtDateOfBirth.Text);

                _customerService.Update();
                BindGridView();
            }
        }

        protected void btndlt_Click(object sender, EventArgs e)
        {
            string id = gv.SelectedRow.Cells[1].Text.ToString();
            _customerService.Delete();
            BindGridView();
        }
    }
}
