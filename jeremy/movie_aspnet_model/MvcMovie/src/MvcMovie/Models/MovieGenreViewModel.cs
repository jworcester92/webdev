using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie.Models
{
    public class MovieGenreViewModel
    {
        public List<Movie> movies;
        public Microsoft.AspNetCore.Mvc.Rendering.SelectList genres;
        public string movieGenre { get; set; }
    }
}