using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie.Models
{
    public class Reviews
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string myreview { get; set; }
        public Movie Movie { get; set; }

    }
}
