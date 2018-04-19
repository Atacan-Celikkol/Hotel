using BilgeHotel.Core.Entity;
using System;

namespace BilgeHotel.Model
{
    class EmployeeRoles : IEntity
    {
        public byte EmployeeRoleID { get; set; }
        public string RoleName { get; set; }
        public byte? ReportsTo { get; set; }
        public bool isActive { get; set; }
    }
}
