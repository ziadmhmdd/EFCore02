﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore02.Entities
{
    internal class Department
    {
        public int Id { get; set; }
        public string DeptName { get; set; }

        //[ForeignKey("Manager")]
        //[ForeignKey(nameof(Department.Manager))]
        public int EmpId { get; set; } // FK
        public Employee Manager { get; set; } // Navigational Property
        public List<Employee> Employees { get; set; }
    }
}
