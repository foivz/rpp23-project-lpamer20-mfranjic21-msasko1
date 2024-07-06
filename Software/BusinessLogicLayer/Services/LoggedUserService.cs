using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Services
{
    public static class LoggedUserService
    {
        static Employee loggedUser { get; set; }
        public static void Init(Employee _loggedUser)
        {
            loggedUser = _loggedUser;
        }

        public static Employee GetLoggedUser()
        {
            return loggedUser;
        }
    }
}
