using BilgeHotel.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeHotel.Model
{
    class EmployeeUser : IEntity
    {
        public int EmployeeUserID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool isActive { get; set; }

        //navigation
        public Employee MyProperty { get; set; }

    }
}
