﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRAdminstrationApi
{
    public class EmployeeBase : IEmployee
    {
        public int Id { get; set; }
        public string FirstName { get ; set ; }
        public string lastName { get; set ; }
        public virtual decimal Salary { get; set; }
    }
}

