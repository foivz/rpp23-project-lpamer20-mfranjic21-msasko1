using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class EmployeeRepository
    {
        public Employee GetEmployee(string username)
        {
            using (var context = new RppContext())
            {
                var query = from e in context.Employee
                            where e.username == username
                            select e;

                return query.FirstOrDefault();
            }
        }
    }
}
