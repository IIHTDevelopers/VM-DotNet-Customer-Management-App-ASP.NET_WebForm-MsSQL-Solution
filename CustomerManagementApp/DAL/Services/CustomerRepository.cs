using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using CustomerManagementApp.DAL.Interfaces;

namespace CustomerManagementApp.DAL.Services
{
    public class CustomerRepository : Interfaces.ICustomerRepository
    {
        private CustomerDbContext _context;

        public CustomerRepository(CustomerDbContext context)
        {
            _context = context;
        }

        public Model.CustomerModel GetById(string id)
        {
            return _context.CustomerModels.FirstOrDefault(t => t.Id == int.Parse(id));
        }

        public string GetAll()
        {
            string qry = "select* from CustomerModels";
            return qry;
        }

        public string Add()
        {
            string qry = "insert into CustomerModels(Title, IsCompleted, DueDate)" +
                "values('";
            return qry;
        }

        public string Update()
        {
            var query = "update CustomerModels set Title='";
            return query;
        }

        public string Delete()
        {
            var query = "delete from CustomerModels where Id='";
            return query;
        }
    }
}