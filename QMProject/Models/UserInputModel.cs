using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace QMproject.Models
{
    public class UserInputModel
    {

        [RegularExpression(@"(((0|1)[0-9]|2[0-9]|3[0-1])\/(0[1-9]|1[0-2])\/((19|20)\d\d))$", ErrorMessage = "Invalid date format.")]
        [Display(Name = "Date 1:")]
        [Required(ErrorMessage = "Date1 is mandatory")]
        public string Date1 { get; set; }

        [RegularExpression(@"(((0|1)[0-9]|2[0-9]|3[0-1])\/(0[1-9]|1[0-2])\/((19|20)\d\d))$", ErrorMessage = "Invalid date format.")]
        [Display(Name = "Date 2:")]
        [Required(ErrorMessage = "Date2 is mandatory")]
        public string Date2 { get; set; }

        public string DateDiff { get; set; }
    }
}
