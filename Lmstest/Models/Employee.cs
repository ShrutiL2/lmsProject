using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Lmstest.Models
{
    public partial class Employee
    {
        public Employee()
        {
            InverseManager = new HashSet<Employee>();
            Leaves = new HashSet<Leave>();
        }

        public int Empid { get; set; }

        [Required(ErrorMessage = "name invalid"), MaxLength(10), MinLength(3)]
        [Display(Name = "Employee Name")]
        public string Empname { get; set; }

        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        [Display(Name = "Email")]
        public string Empemail { get; set; }

        [Display(Name = "Department")]
        public string Department { get; set; }
        [Display(Name = "Address")]
        public string Empaddress { get; set; }

        [Required(ErrorMessage = "phone number invalid"), MaxLength(12), MinLength(3)]
        [Display(Name = "Phone Number")]
        public string Phnumber { get; set; }

        [Display(Name = "Username")]
        public string Empusername { get; set; }


        [Display(Name = "Password")]
        
        public string Emppassword { get; set; }

        [Display(Name = "Leaves In Hand")]
        public int? Leaveinhand { get; set; }

        [Display(Name = "Manager Name")]
        public int? Managerid { get; set; }

        

        public virtual Employee Manager { get; set; }
        public virtual ICollection<Employee> InverseManager { get; set; }
        public virtual ICollection<Leave> Leaves { get; set; }
    }
}
