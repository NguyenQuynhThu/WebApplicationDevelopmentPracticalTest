using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PracticalTestMVC.Models
{
    public class Employee
    {
        public int Id { get; set; }
        [Required]
        public string EmployeeID { get; set; }
        [Required]
        public string EmployeeName { get; set; }
        [Required]
        public string Department { get; set; }
        [Required]
        public double Slary { get; set; }
    }
}