using BilgeHotel.Core.Entity;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace BilgeHotel.Model
{
    class Employee : IEntity
    {
        public int EmployeeID { get; set; }


        public byte EmployeeRoleID { get; set; }
        public byte? ReportsTo { get; set; }
        
        
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime HireDate { get; set; }
        public string Address { get; set; }
        public byte?[] Photo { get; set; } 

        //
        public bool isActive { get; set; }

        [NotMapped]
        public int Age { get => (DateTime.Now.Year - BirthDate.Year); }
        [NotMapped]
        public int TotalWorkTime { get => (DateTime.Now.Day - HireDate.Day); }

    }
}
