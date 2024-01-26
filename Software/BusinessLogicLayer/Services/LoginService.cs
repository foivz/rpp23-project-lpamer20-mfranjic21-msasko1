using DataAccessLayer.Repositories;
using EntitiesLayer;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Services
{
    public class LoginService
    {
        public async Task<bool> LoginUsernamePassword(string username, string password)
        {
            var employeeRepository = new EmployeeRepository();
            var employee = await employeeRepository.GetEmployee(username);

            if(employee != null && employee.password == password)
            {
                return true;
            }
            else { 
                return false; 
            }
            
        }
    }
}
