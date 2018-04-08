using System;
using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models
{
    public class Movie
    {
        public int ID { get; set; }

        [StringLength(60, MinimumLength = 3)]       
        [Required(ErrorMessage = "Movie names must be longer then 3 letters")]
        public string Title { get; set; }

        [Display(Name = "Release Date")]
        [DisplayFormat(DataFormatString = "{0:MMM dd, yyyy}")]
        [Required(ErrorMessage = "Please enter the appropriate release date for this movie")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        [Range(1, 100)]
        [DataType(DataType.Currency)]
        [Required(ErrorMessage = "Please enter like this example 3.99. ie XX.XX")]
        public decimal Price { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        [Required(ErrorMessage = "Please enter a name like Comedy,Action, no crazy characters")]
        [StringLength(30)]
        public string Genre { get; set; }

        [Display(Name = "MGAA Rating")]
        [RegularExpression(@"^(G|PG|PG-13|R|NC-17|NR)$")]
        [Required(ErrorMessage = "Only ratings are G PG PG-13 R NC-17 or NR")]
        [StringLength(5)]
        public string Rating { get; set; }





    }
}