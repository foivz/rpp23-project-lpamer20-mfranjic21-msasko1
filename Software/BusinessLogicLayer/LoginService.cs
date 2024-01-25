using DataAccessLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class LoginService
    {
        public bool LoginUsernamePassword (string username, string password)
        {
            var repository = new EmployeeRepository();

            var employee = repository.GetEmployee(username);

           if(employee.password == password)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
