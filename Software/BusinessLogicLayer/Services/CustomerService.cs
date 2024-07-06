using DataAccessLayer.Repositories;
using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class CustomerService
    {
        public List<Customer> GetCustomers()
        {
            using (var repo = new CustomerRepository())
            {
                return repo.GetAll().ToList();
            }
        }

        public List<String> GetCustomersFullName()
        {
            using (var repo = new CustomerRepository())
            {
                return repo.GetAllNames().ToList();
            }
        }

        public bool AddCustomer(Customer customer)
        {
            bool isSuccessful = false;
            using (var repo = new CustomerRepository())
            {
                int affectedRows = repo.Add(customer);
                isSuccessful = affectedRows > 0;
            }
            return isSuccessful;            

        }

        public bool RemoveCustomer(Customer customer)
        {
            bool isSuccessful = false;

            var support = new SupportServices().GetUsersQuestions(customer);

            if (support.Count != 0)
            {
                throw new CustomerSupportException("Korisnik ima pitanja za korisničku podršku.");
            }

            using (var repo = new CustomerRepository())
            {
                int affectedRows = repo.Remove(customer);
                isSuccessful = affectedRows > 0;
            }
            return isSuccessful;
        }

        public List<Customer> GetCustomersByLastName(string phrase)
        {
            using (var repo = new CustomerRepository())
            {
                return repo.GetCustometByLastName(phrase).ToList();
            }
        }

        public bool CheckIfBlocked(Customer customer)
        {
            return customer.blocked;
        }

        public bool BlockCustomer(Customer customer)
        {
            customer.blocked = !CheckIfBlocked(customer);
            bool isSuccessful = false;

            using (var repo = new CustomerRepository())
            {
                int affectedRows = repo.Update(customer);
                isSuccessful = affectedRows > 0;
            }

            return isSuccessful;
        }
        public Customer GetCustomerByName(string text)
        {
            using (var repo = new CustomerRepository())
            {
                return repo.GetCustometByFullName(text);
            }
        }


        public List<Customer> GetBlocked(bool blocked)
        {
            using (var repo = new CustomerRepository())
            {
                return repo.GetBlockedCustomers(blocked).ToList();
            }
        }
    }
}
