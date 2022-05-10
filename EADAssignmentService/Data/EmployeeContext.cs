using EADAssignmentService.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EADAssignmentService.Data
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext() : base("name=EADAssignment")
        {
        }
        public DbSet<Employee> Employee { get; set; }
        
    }
}