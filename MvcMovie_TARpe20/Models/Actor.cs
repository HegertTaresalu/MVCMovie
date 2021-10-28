using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie_TARpe20.Models
{
    public class Actor
    {
        public int Id { get; set; }

        [Required]
        [StringLength(25,MinimumLength = 2)]
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$",ErrorMessage = "ainult tähtesi võib kasutada")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$", ErrorMessage = "ainult tähtesi võib kasutada")]
        [StringLength(50, MinimumLength = 2)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Date Of Birth")]
        [DataType(DataType.Date)]

        public DateTime DateOfBirth { get; set; }


        [Display(Name = "Number Of Oscars")]
        public int NumberOfOscars { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$", ErrorMessage = "ainult tähtesi võib kasutada")]
        [Display(Name = "Birth place")]
        public string BirthPlace { get; set; }

        [Display(Name = "Net Worth")]
        public int NetWorth { get; set; }



    }
}
