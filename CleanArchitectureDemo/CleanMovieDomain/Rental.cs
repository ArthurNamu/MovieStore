﻿namespace CleanMovie.Domain
{
    public class Rental
    {
        public int RentalId { get; set; }
        public DateTime RenatDate { get; set; }
        public DateTime RentalExpiry { get; set; }
        public decimal TotalCost { get; set; }

        //One to Many Relationships
        public ICollection<Member> Members { get; set; }
    }
}