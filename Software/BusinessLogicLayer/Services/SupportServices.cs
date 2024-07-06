using DataAccessLayer.Repositories;
using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class SupportServices
    {
        public List<Support> GetQuestions()
        {
            using (var repo = new SupportRepository())
            {
                return repo.GetAll().ToList();
            }
        }

        public bool AddQuestion(Support support)
        {
            bool isSuccessful = false;
            using (var repo = new SupportRepository())
            {
                int affectedRows = repo.Add(support);
                isSuccessful = affectedRows > 0;
            }
            return isSuccessful;
        }

        public bool RemoveQuestion(Support support)
        {
            bool isSuccessful = false;
            using (var repo = new SupportRepository())
            {
                int affectedRows = repo.Remove(support);
                isSuccessful = affectedRows > 0;
            }
            return isSuccessful;
        }

        public List<Support> GetQuestionsIfAnswered(bool answered)
        {
            using (var repo = new SupportRepository())
            {
                return repo.GetQuestionsIfAnswered(answered).ToList();
            }
        }


        public List<Support> GetQuestionsByCustomer(string customer)
        {
            using (var repo = new SupportRepository())
            {
                return repo.GetQuestionsByCustomer(customer).ToList();
            }
        }

        public List<Support> GetQuestionsByEmployee(string employee)
        {
            using (var repo = new SupportRepository())
            {
                return repo.GetQuestionsByEmployee(employee).ToList();
            }
        }

        public List<Support> GetUsersQuestions(Customer customer)
        {
            using (var repo = new SupportRepository())
            {
                return repo.GetUsersQuestions(customer).ToList();
            }
        }

        public bool UpdateQuestion(Support support)
        {
            bool isSuccessful = false;
            using (var repo = new SupportRepository())
            {
                int affectedRows = repo.Update(support);
                isSuccessful = affectedRows > 0;
            }
            return isSuccessful;
        }
    }
}
