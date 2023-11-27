using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerManagementApp.Model;

namespace CustomerManagementApp.DAL.Interfaces
{
    public interface ICustomerService
    {
        string GetAll();
        string Add();
        string Update();
        string Delete();
        CustomerModel GetById(string id);
    }
}
