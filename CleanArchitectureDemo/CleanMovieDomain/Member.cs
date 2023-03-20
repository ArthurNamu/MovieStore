using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanMovie.Domain
{
    public class Member
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public  string Email { get; set; }

        //Linking One to Many
        public int RentalId { get; set; }
        public Rental Rental { get; set; }
    }
}
