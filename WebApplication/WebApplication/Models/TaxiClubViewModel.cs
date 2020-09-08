using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Models
{
    public class TaxiClubViewModel
    {

        public IEnumerable<Passenger> PassengersViewModel { get; set; }
        public IEnumerable<Trip> TripViewModel { get; set; }
    }
}
