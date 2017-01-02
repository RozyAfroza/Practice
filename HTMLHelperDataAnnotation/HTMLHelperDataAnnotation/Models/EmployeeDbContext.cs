using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace HTMLHelperDataAnnotation.Models
{
    public class EmployeeDbContext:DbContext
    {
        public DbSet<Employee> Employees { set; get; }
 
    }
}