using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanMovieDomain
{
    public class Movie
    {
        public int Id { get; set; }
        public string MovieName { get; set; } = String.Empty;
        public decimal RentalCost { get; set; }
        public int RentalDuration { get; set; }

        //Many to Many Relationship
        public IList<MovieRental> MovieRentals { get; set; }
    }
}
