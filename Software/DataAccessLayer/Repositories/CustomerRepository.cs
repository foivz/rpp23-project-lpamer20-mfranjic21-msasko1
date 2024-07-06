using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class CustomerRepository : Repository<Customer>
    {
        public CustomerRepository() : base(new Database())
        {
        }

        public override int Update(Customer entity, bool saveChanges = true)
        {
            var customer = Entities.SingleOrDefault(c => c.id == entity.id);

            customer.firstName = entity.firstName;
            customer.lastName = entity.lastName;
            customer.phone = entity.phone;
            customer.email = entity.email;
            customer.adress = entity.adress;
            customer.blocked = entity.blocked;

            if (saveChanges)
            {
                return SaveChanges();
            } else
            {
                return 0;
            }
        }

        public override int Remove(Customer entity, bool saveChanges = true)
        {
            Entities.Attach(entity);
            Entities.Remove(entity);

            if (saveChanges)
            {
                return SaveChanges();
            } else
            {
                return 0;
            }
        }

        public override IQueryable<Customer> GetAll()
        {
            var query = from c in Entities
                        select c;
            return query;
        }

        public IQueryable<String> GetAllNames()
        {
            var query = from c in Entities
                        select c.firstName + " " + c.lastName;

            return query;
        }

        public Customer GetCustometByFullName(string phrase)
        {
            var query = from c in Entities
                        where (c.firstName + " " + c.lastName) == (phrase)
                        select c;

            return query.FirstOrDefault();
        }

        public IQueryable<Customer> GetCustometByLastName(string phrase)
        {
            var query = from c in Entities
                        where c.lastName.Contains(phrase)
                        select c;

            return query;
        }

        public IQueryable<Customer> GetBlockedCustomers(bool blocked)
        {
            var query = from c in Entities
                        where c.blocked == blocked
                        select c;

            return query;
        }

        public IQueryable<Customer> GetCustomerById(int idCustomer)
        {
            var query = from c in Entities
                        where c.id == idCustomer
                        select c;

            return query;
        }
    }
}
