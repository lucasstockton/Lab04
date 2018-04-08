using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace MvcMovie.Models
{
    public class MPAA
    {


        public string MPRating { get; set; }

        public List<SelectListItem> MPRatingList { get; } = new List<SelectListItem>
        {
        new SelectListItem {Text = "G", Value = "G"},
        new SelectListItem {Text = "PG", Value = "PG"},
        new SelectListItem {Text = "PG-13", Value = "PG-13"},
        new SelectListItem {Text = "R", Value = "R"},
        new SelectListItem {Text = "NC-17", Value = "NC-17"},
        new SelectListItem {Text = "NR", Value = "NR"}
        };


    }
}






/*
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace FormsTagHelper.ViewModels
{
    public class CountryViewModel
    {
        public string Country { get; set; }

        public List<SelectListItem> Countries { get; } = new List<SelectListItem>
        {
            new SelectListItem { Value = "MX", Text = "Mexico" },
            new SelectListItem { Value = "CA", Text = "Canada" },
            new SelectListItem { Value = "US", Text = "USA"  },
        };
    }
} */