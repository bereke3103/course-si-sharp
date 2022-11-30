﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBeregovoy.SoftDevelop.Domain
{
    public  class Staff : Person
    {
        public decimal MonthSalary { get; }

        public Staff(string name, decimal monthSalary, List<TimeRecord> timeRecords) : base(name, timeRecords)
        {
            MonthSalary= monthSalary;
        }
    }
}
