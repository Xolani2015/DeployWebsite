using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Models
{
    public class Trip
    {
        [Display(Name = "ID")]
        [Key]
        public int id { get; set; }

        [Display(Name = "Name")]
        public string Name { get; set; }

        [Display(Name = "Surname")]
        public string Surname { get; set; }

        [Display(Name = "Gender")]
        public string Gender { get; set; }

        [Display(Name = "BirthDate")]
        public string BirthDate { get; set; }

        [Display(Name = "Email")]
        public string Email { get; set; }

        [Display(Name = "Cell")]
        public string Cell { get; set; }

        [Display(Name = "HomeAddress")]
        public string HomeAddress { get; set; }

        [Display(Name = "PickUpLocation")]
        public string PickUpLocation { get; set; }

        [Display(Name = "DropOffLocation")]
        public string DropOffLocation { get; set; }

        [Display(Name = "Temp")]
        public string Temp { get; set; }

        [Display(Name = "PickUpArea")]
        public string PickUpArea { get; set; }

        [Display(Name = "DropOfArea")]
        public string DropOffArea { get; set; }

        [Display(Name = "ArrivalTime")]
        public string ArrivalTime { get; set; }

        [Display(Name = "DropOfArea")]
        public string DepartureTime { get; set; }

        [Display(Name = "Bill")]
        public string Bill { get; set; }

        [Display(Name = "TripID")]
        public int TripID { get; set; }

        [Display(Name = "DriverID")]
        public int DriverID { get; set; }

        [Display(Name = "TripID")]
        public int PickUpAreaID { get; set; }

        [Display(Name = "Bill")]
        public int DropOffAreaID { get; set; }

        [Display(Name = "Bill")]
        public string HasDriver { get; set; }
    }
}
