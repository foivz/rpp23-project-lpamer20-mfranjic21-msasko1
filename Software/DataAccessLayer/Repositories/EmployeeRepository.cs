using EntitiesLayer;
using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class EmployeeRepository
    {
        public async Task<Employee> GetEmployee(string username)
        {
            using (var context = new Database())
            {
                var employee = await (from e in context.Employees
                            where e.username == username
                            select e).FirstOrDefaultAsync();

                return employee;
            }
        }
    }
}
