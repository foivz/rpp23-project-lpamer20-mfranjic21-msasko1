using DataAccessLayer.Repositories;
using EntitiesLayer;
using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Services
{
    public class EmployeeService
    {
        public Employee GetEmployee(string username)
        {
            var employeeRepository = new EmployeeRepository();

            var employee = employeeRepository.GetEmployee(username);

            return employee;
        }
    }
}
