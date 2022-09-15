using System;
using System.Collections.Generic;

namespace HRMS.Models
{
    public partial class Employee
    {
        public string? FistName { get; set; }
        public string? MiddleName { get; set; }
        public string? LastName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string? Department { get; set; }
        public string? AdharImagePath { get; set; }
        public string? PanImagePath { get; set; }
        public int EmpId { get; set; }
    }
}
