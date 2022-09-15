using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Lmstest.Models
{
    public partial class Leave : IValidatableObject
    {
        public int Leaveid { get; set; }
        public int? Empid { get; set; }

        public int? Manid { get; set; }

        [Required(ErrorMessage = "The start date is required")]
        [Display(Name = "Start Date:")]
        public DateTime? Leavefrom { get; set; }

        [Required(ErrorMessage = "The end date is required")]
        [Display(Name = "End Date:")]
        public DateTime? Leaveto { get; set; }


        public int? Noofdays { get; set; }
        public string Leavestatus { get; set; }
        public string Leavetype { get; set; }

        public virtual Employee Emp { get; set; }

        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            if (Leaveto < Leavefrom)
            {
                yield return new ValidationResult("EndDate must be greater than StartDate");
                // return Ok("invalid date");

            }
        }
    }
}
