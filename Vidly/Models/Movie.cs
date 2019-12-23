using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public DateTime CreatedAt { get; set; }
        public int NoOfStocks { get; set; }

        public Genre Genre { get; set; }
        public byte GenreId { get; set; }


        //create a constructor method a default value
        public Movie()
        {
            this.CreatedAt = DateTime.UtcNow;
        }
    }


}