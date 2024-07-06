using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class SupportRepository : Repository<Support>
    {
        public SupportRepository() : base(new Database())
        {
        }

        public override int Add(Support entity, bool saveChanges = true)
        {
            var support = new Support();

            if (entity.Customer != null)
            {
                var customer = Context.Customers.SingleOrDefault(c => c.id == entity.Customer.id);
                support.Customer = customer;
                support.user = customer.id;
            }
            if (entity.Employee1 != null)
            {
                var employee = Context.Employees.SingleOrDefault(e => e.id == entity.Employee1.id);
                support.Employee1 = employee;
                support.employee = employee.id;
            }

            support.message = entity.message;
            support.message_date = entity.message_date;
            support.answer = entity.answer;
            support.answer_date = entity.answer_date;

            Entities.Add(support);
            if (saveChanges)
            {
                return SaveChanges();
            } else
            {
                return 0;
            }
        }

        public override int Update(Support entity, bool saveChanges = true)
        {
            var support = Entities.SingleOrDefault(c => c.id == entity.id);

            if (entity.Employee1 != null)
            {
                var employee1 = Context.Employees.SingleOrDefault(e => e.id == entity.Employee1.id);
                support.Employee1 = employee1;
            }

            support.answer = entity.answer;
            support.answer_date = entity.answer_date;

            if (saveChanges)
            {
                return SaveChanges();
            } else
            {
                return 0;
            }
        }

        public override IQueryable<Support> GetAll()
        {
            var query = from s in Entities.Include("Customer").Include("Employee1")
                        select s;
            return query;
        }

        public IQueryable<Support> GetQuestionsIfAnswered(bool answered)
        {
            var query = from s in Entities.Include("Customer").Include("Employee1")
                        where (s.answer != null) == answered
                        select s;

            return query;
        }

        public IQueryable<Support> GetQuestionsByCustomer(string customer)
        {
            var query = from s in Entities.Include("Customer").Include("Employee1")
                        where (s.Customer.firstName + " " + s.Customer.lastName).Contains(customer)
                        select s;

            return query;
        }

        public IQueryable<Support> GetQuestionsByEmployee(string employee)
        {
            var query = from s in Entities.Include("Customer").Include("Employee1")
                        where (s.Employee1.firstName + " " + s.Employee1.lastName).Contains(employee)
                        select s;

            return query;
        }

        public IQueryable<Support> GetUsersQuestions(Customer customer)
        {
            var query = from s in Entities.Include("Customer").Include("Employee1")
                        where (s.Customer.id).Equals(customer.id)
                        select s;

            return query;
        }
    }
}
