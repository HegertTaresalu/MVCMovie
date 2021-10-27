using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie_TARpe20.Models
{
    public class Actors
    {
        public int Id { get; set; }

        [Required]
        [StringLength(25,MinimumLength = 2)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 2)]
        public string LastName { get; set; }


        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }


        [Required]
        [DataType(DataType.Currency)]
        public int Salary { get; set; }




    }
}
