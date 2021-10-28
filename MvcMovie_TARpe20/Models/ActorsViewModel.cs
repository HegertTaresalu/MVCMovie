using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie_TARpe20.Models
{
    public class ActorsViewModel
    {
        public List<Actor> Actors { get; set; }

        public SelectList BirthYears { get; set; }

        public string SearchString { get; set; }

        public DateTime BirthYear { get; set; }
    }
}
