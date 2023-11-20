using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using CustomerManagementApp.DAL.Interfaces;
using CustomerManagementApp.Model;

namespace CustomerManagementApp.DAL.Services
{
    public class CustomerService : Interfaces.ICustomerService
    {
        private Interfaces.ICustomerRepository _repository;

        public CustomerService(Interfaces.ICustomerRepository repository)
        {
            _repository = repository;
        }


        public string GetAll()
        {
            return _repository.GetAll();
        }

        public string Add()
        {
            return _repository.Add();
        }

        public string Update()
        {
            return _repository.Update();
        }

        public string Delete()
        {
            return _repository.Delete();
        }

        public CustomerModel GetById(string id)
        {
            return _repository.GetById(id);
        }
    }
}